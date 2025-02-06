using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrencıSıstemı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Set the main form as an MDI container
        }

        FrmOGRETMENLER frm1;
        FrmOgrenciler frmOgrenciler;
        private SqlConnection bgl; // Changed object to SqlConnection
        private ComboBox comboBox1; // Changed object to ComboBox

        public ComboBox Cmbil { get; private set; } // Changed object to ComboBox

        private void BTNOgretmenler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new FrmOGRETMENLER();
                frm1.Show();
            }
        }

        void ilekle()
        {
            SqlCommand komut = new SqlCommand("Select * From dbo.iller", bgl);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbil.Items.Add(dr[1]); // Changed to access Items property directly
            }
            dr.Close();
        }

        private void FrmOGRETMENLER_Load(object sender, EventArgs e)
        {
            ilekle();
        }

        private void BTNOgrenciler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void BTNOgrenciler_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frmOgrenciler == null || frmOgrenciler.IsDisposed)
            {
                frmOgrenciler = new FrmOgrenciler();
                frmOgrenciler.Show();
            }
        }

        private void BTNAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}
