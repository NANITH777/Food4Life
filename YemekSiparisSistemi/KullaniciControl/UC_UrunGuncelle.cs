using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace YemekSiparisSistemi.KullaniciControl
{
    public partial class UC_UrunGuncelle : UserControl
    {
        Yiyecek yem = new Yiyecek();
        string query;
        public UC_UrunGuncelle()
        {
            InitializeComponent();
        }

        private void UC_UrunGuncelle_Load(object sender, EventArgs e)
        {
            VeriAl();
        }


        // Temizleme fonksiyonu
        private void ClearAll()
        {
            List<TextBox> textBoxes = new List<TextBox> { txtad, txtkalori, txtstok, txtfiyat, txtara };
            foreach (var textbox in textBoxes)
            {
                textbox.Clear();
            }
            dateskt.ResetText();
            dateUretim.ResetText();

        }


        // veritabanından verileri alma metodu
        private void VeriAl()
        {
            query = "select * from Urun Order by Uadi ASC";
            DataSet ds = yem.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }


        // Verileri silme
        private void btnsil_Click(object sender, EventArgs e)
        {
            query = "delete from Urun where Uadi='" + txtad.Text + "'";
            yem.setData(query);
            MessageBox.Show("Silindi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ////Urunler.txt dosyasından bir ürün silmek
            string filePath = "Urunler.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains(txtad.Text))
                {
                    lines.RemoveAt(i);
                    break;
                }
            }

            File.WriteAllLines(filePath, lines);

            ClearAll();
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Urun where Uadi like '" + txtara.Text + "%'";
            DataSet ds = yem.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ad = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string uretimtarihi = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            string sktarihi = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            float kalorigram = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            float stokadet = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            float fiyat = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());

            txtad.Text = ad;
            dateUretim.Value = DateTime.Parse(uretimtarihi);
            dateskt.Value = DateTime.Parse(sktarihi);
            txtfiyat.Text = fiyat.ToString();
            txtkalori.Text = kalorigram.ToString();
            txtstok.Text = stokadet.ToString();
        }

        private void UC_UrunGuncelle_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Urun where Uadi like '" + txtara.Text + "%'";
            DataSet ds = yem.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }


        // Verileri Güncelleme 
        private void btnguncelleme_Click(object sender, EventArgs e)
        {
            query = "update Urun set Uadi= '" + txtad.Text + "', uretimtarihi='" + dateUretim.Value.ToString("yyyy-MM-dd") + "', sktarih='" + dateskt.Value.ToString("yyyy-MM-dd") + "', kalorigram=" + Convert.ToDouble(txtkalori.Text) + ", stokadet=" + Convert.ToDouble(txtstok.Text) + ", fiyat=" + Convert.ToDouble(txtfiyat.Text) + " where Uadi='" + txtad.Text + "' ";
            yem.setData(query);


            // Urunler.txt dosyasında güncelleme yapmak
            string filePath = "Urunler.txt";
            string[] lines = File.ReadAllLines(filePath);

            List<string> linesList = lines.ToList();

            for (int i = 0; i < linesList.Count; i++)
            {
                if (linesList[i].Contains(txtad.Text))
                {
                    string urunBilgisi = txtad.Text + " - Üretim Tarihi: " + dateUretim.Value.ToString("yyyy-MM-dd") + " - Son Kullanma Tarihi: " + dateskt.Value.ToString("yyyy-MM-dd") + " - Kalori: " + txtkalori.Text + " - Stok Adeti: " + txtstok.Text + " - Fiyat: " + txtfiyat.Text;
                    linesList[i] = urunBilgisi;
                    break;
                }
            }

            File.WriteAllLines(filePath, linesList.ToArray());
            ///////////////////////////         


            VeriAl();
            ClearAll();
        }
    }
}
