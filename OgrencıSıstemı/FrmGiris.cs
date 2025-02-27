using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrencıSıstemı
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        {
            // Load event logic here
        }

        private void BtnYonetici_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OGRTTC,OGRTSIFRE from TBL_AYARLAR inner join TBL_OGRETMENLER on TBL_AYARLAR.AYARLARID=TBL_OGRETMENLER.OGRTID where OGRTTC=@p1 and OGRTSIFRE=@p2",bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
           

             private void BtnGiris_click(object sender, EventArgs e)
        {
            string kullanici = MskTC.Text;
            string sifre = TxtSifre.Text;

            // Kullanıcı adı ve şifreyi kontrol et (veritabanı veya sabit değerler kullanılabilir)
            if (kullanici == "kullanici" && sifre == "sifre") // Örnek olarak sabit değerler kullanıldı
            {
              Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }



  /*Form1 aUniversitesiFormu = new Form1(); // Form2, A Üniversitesi menüsünün bulunduğu form
                aUniversitesiFormu.Show();
                this.Hide(); // Giriş formunu gizle





           /* if (dr.Read())
            {
                
        }*/

        private class Form1
        {
            internal void Show()
            {
                throw new NotImplementedException();
            }
        }
    }
}
