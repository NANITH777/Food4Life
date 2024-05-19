using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YemekSiparisSistemi.KullaniciControl
{
    public partial class UC_UrunEkle : UserControl
    {
        Yiyecek yem = new Yiyecek();
        string query;
        public UC_UrunEkle()
        {
            InitializeComponent();
        }

        // Formu temizleme fonksiyonu
        private void ClearAll()
        {
            List<TextBox> textBoxes = new List<TextBox> { txtad, txtkalori, txtstok, txtfiyat };
            foreach(var textbox in textBoxes)
            {
                textbox.Clear();
            }
            dateskt.ResetText();
            dateUretim.ResetText();

        }


        // Ürün Ekleme 
        private void btnekle_Click(object sender, EventArgs e)
        {
            query = "insert into Urun(Uadi, uretimtarihi, sktarih, kalorigram, stokadet, fiyat) values ('" + txtad.Text + "', '" + dateUretim.Value.ToString("yyyy-MM-dd") + "', '" + dateskt.Value.ToString("yyyy-MM-dd") + "', " + Convert.ToDouble(txtkalori.Text) + ", " + Convert.ToDouble(txtstok.Text) + ", " + Convert.ToDouble(txtfiyat.Text) + ")";
            yem.setData(query);
            MessageBox.Show("Veri eklendi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            if (!File.Exists("Urunler.txt"))
            {
                File.CreateText("Urunler.txt").Close();
            }

            string urunBilgisi = txtad.Text + " - Üretim Tarihi: " + dateUretim.Value.ToString("yyyy-MM-dd") + " - Son Kullanma Tarihi: " + dateskt.Value.ToString("yyyy-MM-dd") + " - Kalori: " + txtkalori.Text + " - Stok Adeti: " + txtstok.Text + " - Fiyat: " + txtfiyat.Text;
            File.AppendAllText("Urunler.txt", urunBilgisi + Environment.NewLine);

            ClearAll();
        }

        private void UC_UrunEkle_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
