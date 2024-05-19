using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparisSistemi.KullaniciControl
{
    public partial class UC_Yemekmalzemeleri : UserControl
    {
        Yiyecek yem = new Yiyecek();
        string query;
        public UC_Yemekmalzemeleri()
        {
            InitializeComponent();
        }

        // Temizleme metodu
        private void ClearAll()
        {
            txtmalzemeler.Clear();
            txtara.Clear();
            txtyemekadi.Clear();
        }


        private void txtara_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Yiyecek where adi like '" + txtara.Text + "%'";
            DataSet ds = yem.getData(query);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                string yemekAdi = ds.Tables[0].Rows[0]["adi"].ToString();

                txtyemekadi.Text = yemekAdi;
            }
            else
            {
                txtyemekadi.Text = "";
            }
        }


        // Verileri ekleme
        private void button1_Click(object sender, EventArgs e)
        {
            query= "insert into YemekMalzemeler(yemekadi, malzemeler) values('"+txtyemekadi.Text+"', '"+txtmalzemeler.Text+"')";
            yem.setData(query);
            MessageBox.Show("Veri eklendi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            
            if (!File.Exists("YemekMalzemeleri.txt"))
            {
                File.CreateText("YemekMalzemeleri.txt").Close();
            }

            string MalzemeBilgisi = txtyemekadi.Text + "  :   " + txtmalzemeler.Text;
            File.AppendAllText("YemekMalzemeleri.txt", MalzemeBilgisi + Environment.NewLine);

            UC_MalzemelerGuncelle malzemelerGuncelle = new UC_MalzemelerGuncelle();
            malzemelerGuncelle.VeriAl();
            ClearAll();
        }

        private void UC_Yemekmalzemeleri_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
