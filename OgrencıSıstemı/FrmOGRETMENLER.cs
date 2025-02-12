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
    public partial class FrmOGRETMENLER : Form
    {
        public FrmOGRETMENLER()
        {
            InitializeComponent();
        }
        private sqlbaglantisi bgl = new sqlbaglantisi();

        private void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from dbo.TBL_OGRETMEN", bgl.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmOGRETMENLER_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into dbo.TBL_OGRETMEN (OGRTAD,OGRTSOYAD,OGRTTC,OGRTTEL,OGRTMAIL,OGRTIL,OGRTILCE,OGRTBRANS) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTc.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", Txtmail.Text);
            komut.Parameters.AddWithValue("@p6", Cmbil.Text);
            komut.Parameters.AddWithValue("@p7", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", Cmbbrans.Text);
            komut.ExecuteNonQuery();

            bgl.Baglanti().Close();
            MessageBox.Show("Öğretmen Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        public static implicit operator FrmOgrenciler(FrmOGRETMENLER v)
        {
            // Implement the conversion logic here
            FrmOgrenciler frmOgrenciler = new FrmOgrenciler();
            // Copy necessary properties from v to frmOgrenciler
            return frmOgrenciler;
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbil.Items.Clear();
            Cmbil.Text = "";
            SqlCommand komut = new SqlCommand("Select IL from dbo.ILLER where sehiradi=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbil.Items.Add(dr[1]);
            }
            dr.Close();
        }
    }

    internal class OGRTTEL
    {
    }
}
