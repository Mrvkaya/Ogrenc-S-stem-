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
using System.IO;

namespace OgrencıSıstemı
{
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl;

        private void Btnkaydet_Click(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void Cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        void listele()
        {
            //5.Sınıf öğrencilerini listele
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_OGRENCILER where OGRSINIF='1'", bgl.Baglanti());
            da.Fill(dt1);
            gridControl1.DataSource = dt1;

            //6.Sınıf öğrencilerini listele
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from TBL_OGRENCILER where OGRSINIF='2'", bgl.Baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;

            //7.Sınıf öğrencilerini listele
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from TBL_OGRENCILER where OGRSINIF='3'", bgl.Baglanti());
            da3.Fill(dt3);
            gridControl3.DataSource = dt3;
            DataTable dt4 = new DataTable();


            //8.Sınıf öğrencilerini listele
            SqlDataAdapter da4 = new SqlDataAdapter("Select * from TBL_OGRENCILER where OGRSINIF='4'", bgl.Baglanti());
            da4.Fill(dt4);
            gridControl4.DataSource = dt4;
            DataTable dt5 = new DataTable();

        }

        private void sehirListesi()
        {
            // Şehirlerin listesini getir
            SqlCommand komut = new SqlCommand("SELECT * FROM TBL_ILLER", bgl.Baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string satir = "";

                // Satırdaki tüm sütunları sırayla al ve ekle
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    satir += dr[i].ToString() + " ";  // Her sütunu birleştir, aralarına boşluk koyarak
                }

                // Sütunları birleştirip Combobox'a ekle
                Cmbil.Items.Add(satir.Trim());
            }

            bgl.Baglanti().Close();

        }


        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            bgl = new sqlbaglantisi();
            listele();
            sehirListesi();
        }
    }
}
