using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace YemekSiparisSistemi.KullaniciControl
{
    public partial class UC_YemekEkleme : UserControl
    {
        Yiyecek yem = new Yiyecek();
        string query;
        public UC_YemekEkleme()
        {
            InitializeComponent();
        }


        //Yemek Ekleme 
        private void button1_Click(object sender, EventArgs e)
        {
            query = "insert into Yiyecek(adi, cins, fiyat, kdvorani) values('"+txtad.Text+"', '"+combocins.Text+"', "+txtfiyat.Text+", "+txtoran.Text+")";
            yem.setData(query);
            MessageBox.Show("Veri eklendi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAll();
        }

        
        /// Formu temizle
        public void ClearAll()
        {
            List<TextBox> textBoxes = new List<TextBox> { txtad, txtfiyat, txtoran };
            combocins.SelectedIndex = -1;

            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }

        private void UC_YemekEkleme_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
