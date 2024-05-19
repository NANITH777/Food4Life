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
    public partial class UC_YemekGuncelleme : UserControl
    {
        Yiyecek yem =new Yiyecek();
        string query;
        public UC_YemekGuncelleme()
        {
            InitializeComponent();
            VeriAl();
        }

        //    Temizleme metodu 
        public void AllClear()
        {
            combocins.ResetText();
            txtoran.Clear();
            txtfiyat.Clear();
            txtara.Clear();
            txtad.Clear();
        }
        private void UC_YemekGuncelleme_Load(object sender, EventArgs e)
        {
            VeriAl();
        }


        // Veritabanından Verileri alma Datagridview'e görüntülemek için
        public void VeriAl()
        {
            query = "select adi, cins, fiyat, kdvorani from Yiyecek Order by adi";
            DataSet ds = yem.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void txtara_TextChanged(object sender, EventArgs e)
        {
            query="select * from Yiyecek where adi like '"+txtara.Text+"%'";
            DataSet ds = yem.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private string eskiyemekadi;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ad = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string cins=(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            float fiyat = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            float kdvorani = Convert.ToSingle(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtad.Text = ad;
            combocins.Text = cins;
            txtfiyat.Text = fiyat.ToString();
            txtoran.Text = kdvorani.ToString();

            eskiyemekadi = ad;
        }

        private void btnguncelleme_Click(object sender, EventArgs e)
        {
            // veritabani komutu kullanarak güncelleme yapmak 
            query = "update Yiyecek set adi= '"+txtad.Text+ "', cins='" + combocins.Text + "', fiyat=" + Convert.ToDouble(txtfiyat.Text) + ", kdvorani=" + Convert.ToDouble(txtoran.Text) + " where  adi='" + eskiyemekadi+"' ";
            yem.setData(query);
            VeriAl();
            AllClear();
        }

        private void UC_YemekGuncelleme_Leave(object sender, EventArgs e)
        {
            AllClear();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //  veritabani komutu kullarak verileri silmek
            query = "delete from Yiyecek where adi='" + txtad.Text + "'";
            yem.setData(query);
            MessageBox.Show("Silindi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VeriAl();
            AllClear();
        }
    }
}
