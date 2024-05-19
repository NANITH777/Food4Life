using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparisSistemi
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }


        // Kullanici'ye göre Sipariş Sistemi görüntüsü
        public Menuform(string kullanici)
        {
            InitializeComponent();

            if(kullanici=="Admin")
            {
                btnyemekekleme.Show();
                btnyemekguncelleme.Show();
                btnurunekleme.Show();
                btnurunguncelleme.Show();
                btnMalzemeEkle.Show();
                btnmalguncelle.Show();
                btnLokantaRaporu.Show();
            }
            else if(kullanici=="Musteri")
            {
                btnyemekekleme.Hide();
                btnyemekguncelleme.Hide();
                btnurunekleme.Hide();
                btnurunguncelleme.Hide();
                btnMalzemeEkle.Hide();
                btnmalguncelle.Hide();
                btnLokantaRaporu.Hide();
            }
        }

        private void Menuform_Load(object sender, EventArgs e)
        {
            uC_YemekEkleme1.Visible = false;
            uC_Siparis1.Visible = false;
            uC_YemekGuncelleme1.Visible = false;
            uC_UrunEkle1.Visible = false;
            uC_UrunGuncelle1.Visible = false;
            uC_Yemekmalzemeleri1.Visible = false;
            uC_MalzemelerGuncelle1.Visible = false;
            uC_LokantaRaporu1.Visible = false;
        }

        // Sistemden çıkmak
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Logout yapmak
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

      
        // Malzemeler Ekleme KUllanici Kontrolü
        private void btnMalzemeEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uC_Yemekmalzemeleri1.Visible = true;
            uC_Yemekmalzemeleri1.BringToFront();
        }


        // Malzemler güncelleme Kullanici Kontrolü
        private void btnmalguncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uC_MalzemelerGuncelle1.Visible = true;
            uC_MalzemelerGuncelle1.BringToFront();
        }


        // Sipariş için Kullanici Kontrolü
        private void btnSiparis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uC_Siparis1.Visible = true;
            uC_Siparis1.BringToFront();
        }


        // Yemek ekleme Kullanici Kontrolü
        private void btnyemekekleme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uC_YemekEkleme1.Visible = true;
            uC_YemekEkleme1.BringToFront();
        }


        // Yemek güncelleme Kullanici Kontrolü
        private void btnyemekguncelleme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uC_YemekGuncelleme1.Visible = true;
            uC_YemekGuncelleme1.BringToFront();
        }


        // Ürün ekleme kullanici kontrolü
        private void btnurunekleme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uC_UrunEkle1.Visible = true;
            uC_UrunEkle1.BringToFront();
        }


        // Ürğn güncelleme Kullanici KOntrolü
        private void btnurunguncelleme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uC_UrunGuncelle1.Visible = true;
            uC_UrunGuncelle1.BringToFront();
        }
        

        // Lokanta Raporu Kullanici kontrolü
        private void btnLokantaRaporu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uC_LokantaRaporu1.Visible = true;
            uC_LokantaRaporu1.BringToFront();
        }
    }
}
