using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparisSistemi.KullaniciControl
{
    public partial class UC_Siparis : UserControl
    {
        Yiyecek yem = new Yiyecek();
        string query;
        public UC_Siparis()
        {
            InitializeComponent();
        }

        // formu temizleme metodu
        public void ClearAll()
        {
            List<TextBox> TextBoxes = new List<TextBox> {txtara, txtad, txtfiyat, txtoran, txttoplam };
            comboyemek.SelectedIndex = -1;
            listBox1.Items.Clear();
            miktarUpDown1.ResetText();
            foreach(var TextBox in TextBoxes )
            {
                TextBox.Clear();
            }
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string cins = comboyemek.Text;
            query = "select adi from Yiyecek where cins='" + cins + "' and adi like'"+txtara.Text+"%'";
            YemekGoster(query);
        }

        private void comboyemek_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string cins = comboyemek.Text;
            query = "select adi from Yiyecek where cins='" + cins + "' ";
            YemekGoster(query);
        }


        // Cin.combobox'tan alındığı yemek cinsi listBox'a gösterme fonksiyonu
        private void YemekGoster(string query)
        {
            listBox1.Items.Clear();
            DataSet ds = yem.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }


        // listbox'tan seçildiği yemekadı uygun textbox'lara görüntelemek
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            miktarUpDown1.ResetText();
            txttoplam.Clear();

            string metin = listBox1.GetItemText(listBox1.SelectedItem);
            txtad.Text= metin;
            query = "select fiyat, kdvorani from Yiyecek where adi='" + metin + "'";
            DataSet ds = yem.getData(query);

            try
            {
                txtfiyat.Text = ds.Tables[0].Rows[0][0].ToString();
                txtoran.Text = ds.Tables[0].Rows[0][1].ToString();
            }
            catch { }
        }

        protected int n=0;
        float toplam=0;

        private void miktarUpDown1_ValueChanged(object sender, EventArgs e)
        {
            float miktar = Convert.ToSingle(miktarUpDown1.Value.ToString());
            float fiyat = Convert.ToSingle(txtfiyat.Text);
            txttoplam.Text = (miktar * fiyat).ToString();
        }


        // Siparis ekleme
        private void btnekle_Click(object sender, EventArgs e)
        {

            if (txttoplam.Text != "0" && txttoplam.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtad.Text;
                dataGridView1.Rows[n].Cells[1].Value = comboyemek.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtfiyat.Text;
                dataGridView1.Rows[n].Cells[3].Value = txtoran.Text;
                dataGridView1.Rows[n].Cells[4].Value = miktarUpDown1.Value;
                dataGridView1.Rows[n].Cells[5].Value = txttoplam.Text;

                toplam += Convert.ToSingle(txttoplam.Text);
                labeltoplam.Text = "Tutar:" + toplam;
            }
            else
                MessageBox.Show(" minimum bir(1) olmasi lazim ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }


        float tutar;


        // Sipariş Silme
        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                tutar = Convert.ToSingle(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[5].Value.ToString());

                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                toplam -= tutar;
                labeltoplam.Text = "Tutar: " + toplam.ToString();
            }
            catch { }

        }


        // Sipariş Yazdırma
        private void btnyazdir_Click(object sender, EventArgs e)
        {

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Müşteri Faturası";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Toplam ödenecek tutar: " + labeltoplam.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);


            //Veritabanına Ekleme(Sipariş tablosuna)
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string yemekadi = row.Cells[0].Value.ToString();
                    string cins = row.Cells[1].Value.ToString();
                    float fiyat = Convert.ToSingle(row.Cells[2].Value);
                    float kdvorani = Convert.ToSingle(row.Cells[3].Value);
                    int miktar = Convert.ToInt32(row.Cells[4].Value);
                    float toplam = Convert.ToSingle(row.Cells[5].Value);


                    query = "insert into Siparis (yemekadi, cins, fiyat, kdvorani, miktar, toplam, tarih) " +
                            "values ('" + yemekadi + "','" + cins + "', " + fiyat + ", " + kdvorani + ", " + miktar + ", " + toplam + ", CURRENT_TIMESTAMP)";


                    yem.setData(query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Kontrolleri sıfırla
            toplam = 0;
            dataGridView1.Rows.Clear();
            labeltoplam.Text = "Toplam:" + toplam;
            ClearAll();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tutar = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            catch { }
        }

        private void UC_Siparis_Leave(object sender, EventArgs e)
        {
            ClearAll();
            dataGridView1.Rows.Clear();
        }
    }
}
