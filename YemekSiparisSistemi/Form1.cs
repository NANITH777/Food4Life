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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Sisteme giriş yapma metodu
        private void button1_Click(object sender, EventArgs e)
        {
            // Admin için( sisteme yöneten kişi)
            if(txtkullanici.Text=="admin" && txtsifre.Text=="1234")
            {
                MessageBox.Show("Login başarılı"," Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menuform menu = new Menuform("Admin");
                menu.ShowDialog();
                this.Hide();
                
            }
            // Müşteri için
            else
            {
                MessageBox.Show("Login başarısız, lütfen kontrol edin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Müşteri için Siparis Sistemine giriş
        private void btnmusteri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menuform menu = new Menuform("Musteri");
            menu.ShowDialog();
            this.Hide();
        }
    }
}
