/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**				  
**				
**	
**				ÖDEV NUMARASI..........:
**				ÖĞRENCİ ADI............: 
**				ÖĞRENCİ NUMARASI.......: 
**              DERSİN ALINDIĞI GRUP...: A
**              
**              ADMIN(KULLANİCİ ADİ)...: admin
**              ADMİN ŞİFRESİ..........: 1234
****************************************************************************/

using System.Data;
using System.Data.SqlClient;


namespace YemekSiparisSistemi
{
    internal class Yiyecek
    {
        // Veritabına Bağlama komutu
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-2H8LHRK;Initial Catalog=YemekSiparisSistemi;Integrated Security=True;";
            return con;
        }


        // Veritanına veriyi saklama metodu
        public DataSet getData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }


        // veritabanından veri alma metodu 
        public void setData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
