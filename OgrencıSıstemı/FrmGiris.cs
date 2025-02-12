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
        private void FrmGiris_Load(object sender, EventArgs e)
        {
            // Load event logic here
        }

        private void BtnYonetici_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_YONETICI where YONETICITC=@p1 and YONETICISIFRE=@p2", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaModul fr = new FrmAnaModul();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class FrmAnaModul
        {
            internal void Show()
            {
                throw new NotImplementedException();
            }
        }
    }
}
