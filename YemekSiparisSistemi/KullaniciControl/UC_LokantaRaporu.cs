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
    public partial class UC_LokantaRaporu : UserControl
    {
        Yiyecek yem=new Yiyecek();
        string query;
        public UC_LokantaRaporu()
        {
            InitializeComponent();
        }

        private void btnYemekListesi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            query = "select * from Yiyecek";
            DataSet ds = yem.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnurunlistesi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            query = "select * from Urun";
            DataSet ds = yem.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnsiparis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            query = "select * from Siparis order by tarih";
            DataSet ds = yem.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSifirla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string disableFK = "ALTER TABLE Siparis NOCHECK CONSTRAINT ALL";
            yem.setData(disableFK);

            query = "truncate table Yiyecek ";
            yem.setData(query);

            string enableFK = "ALTER TABLE Siparis CHECK CONSTRAINT ALL";
            yem.setData(enableFK);
            

            query = "truncate table Urun ";
            yem.setData(query);

            query = "truncate table YemekMalzemeler ";
            yem.setData(query);

            query = "truncate table Siparis ";
            yem.setData(query);

            dataGridView1.DataSource = null;
        }

        private void btnkar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            try
            {
                // Siparis tablosundan "toplam tutarı" toplamını hesaplamak
                query = "select sum(toplam) from Siparis";
                DataSet ds1 = yem.getData(query);
                float gelir = Convert.ToSingle(ds1.Tables[0].Rows[0][0]);

                // Urun tablosundan "toplam fiyat" toplamını hesaplamak
                query = "select sum(fiyat) from Urun";
                DataSet ds2 = yem.getData(query);
                float gider = Convert.ToSingle(ds2.Tables[0].Rows[0][0]);

                // toplam karı hesaplamak
                float kar = gelir - gider;

                // Sonucu Laberler'e göstermek
                lblkar.Text = "Kar: " + kar.ToString() + " TL";
                lblgelir.Text = "Gelir: " + gelir.ToString() + "TL ";
                lblgider.Text = " Gider: " + gider.ToString() + "TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_LokantaRaporu_Leave(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            lblkar.Text = "Kar: 00 TL";
            lblgelir.Text = "Gelir: 00 TL ";
            lblgider.Text = " Gider: 00 TL";
        }
    }
}
