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
    public partial class UC_MalzemelerGuncelle : UserControl
    {
        Yiyecek yem= new Yiyecek();
        string query;

        public UC_MalzemelerGuncelle()
        {
            InitializeComponent();
        }

        public void VeriAl()
        {
            query = "select * from YemekMalzemeler";
            DataSet ds = yem.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void UC_MalzemelerGuncelle_Load(object sender, EventArgs e)
        {
            VeriAl();
        }

        // formu temizleme fonksiyonu
        private void ClearAll()
        {
            txtmalzemeler.Clear();
            txtara.Clear();
            txtyemekadi.Clear();
        }


        // YemekMalzemeler tablosundan arama yaparak yemekadi getirme metodu
        private void txtara_TextChanged(object sender, EventArgs e)
        {
            query = "select * from YemekMalzemeler where yemekadi like '" + txtara.Text + "%'";
            DataSet ds = yem.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }


        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string yemekadi = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string malzemeler = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());

            txtyemekadi.Text = yemekadi;
            txtmalzemeler.Text= malzemeler;

        }


        // Güncelle yapma fonskiyonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            query = "update YemekMalzemeler set yemekadi= '" + txtyemekadi.Text + "', malzemeler='" + txtmalzemeler.Text + "' where yemekadi= '" + txtyemekadi.Text + "' ";
            yem.setData(query);

            // Urunler.txt dosyasında güncelleme yapmak
            string filePath = "YemekMalzemeleri.txt";
            string[] lines = File.ReadAllLines(filePath);

            List<string> linesList = lines.ToList();

            for (int i = 0; i < linesList.Count; i++)
            {
                if (linesList[i].Contains(txtyemekadi.Text))
                {
                    string MalzemeBilgisi = txtyemekadi.Text + "  :   " + txtmalzemeler.Text;
                    linesList[i] = MalzemeBilgisi;
                    break;
                }
            }

            File.WriteAllLines(filePath, linesList.ToArray());
            ///////////////////////////         

            VeriAl();
            ClearAll();
        }


        // silme fonksiyonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            query = "delete from YemekMalzemeler where yemekadi='" + txtyemekadi.Text + "'";
            yem.setData(query);
            MessageBox.Show("Silindi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string filePath = "YemekMalzemeleri.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains(txtyemekadi.Text))
                {
                    lines.RemoveAt(i);
                    break;
                }
            }

            File.WriteAllLines(filePath, lines);

            VeriAl();
            ClearAll();
        }


        private void UC_MalzemelerGuncelle_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
