namespace OgrencıSıstemı
{
    partial class FrmNufusCuzdani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNufusCuzdani));
            this.LblTc = new DevExpress.XtraEditors.LabelControl();
            this.LblAd = new DevExpress.XtraEditors.LabelControl();
            this.LblDogTar = new DevExpress.XtraEditors.LabelControl();
            this.LblCinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.LblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTc
            // 
            this.LblTc.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.Appearance.Options.UseFont = true;
            this.LblTc.Location = new System.Drawing.Point(12, 94);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(82, 14);
            this.LblTc.TabIndex = 0;
            this.LblTc.Text = "labelControl1";
            // 
            // LblAd
            // 
            this.LblAd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAd.Appearance.Options.UseFont = true;
            this.LblAd.Location = new System.Drawing.Point(190, 138);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(82, 14);
            this.LblAd.TabIndex = 1;
            this.LblAd.Text = "labelControl2";
            // 
            // LblDogTar
            // 
            this.LblDogTar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDogTar.Appearance.Options.UseFont = true;
            this.LblDogTar.Location = new System.Drawing.Point(190, 185);
            this.LblDogTar.Name = "LblDogTar";
            this.LblDogTar.Size = new System.Drawing.Size(82, 14);
            this.LblDogTar.TabIndex = 2;
            this.LblDogTar.Text = "labelControl3";
            // 
            // LblCinsiyet
            // 
            this.LblCinsiyet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCinsiyet.Appearance.Options.UseFont = true;
            this.LblCinsiyet.Location = new System.Drawing.Point(326, 185);
            this.LblCinsiyet.Name = "LblCinsiyet";
            this.LblCinsiyet.Size = new System.Drawing.Size(82, 14);
            this.LblCinsiyet.TabIndex = 3;
            this.LblCinsiyet.Text = "labelControl4";
            // 
            // LblSoyad
            // 
            this.LblSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyad.Appearance.Options.UseFont = true;
            this.LblSoyad.Location = new System.Drawing.Point(190, 94);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(82, 14);
            this.LblSoyad.TabIndex = 4;
            this.LblSoyad.Text = "labelControl5";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(24, 138);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(126, 142);
            this.pictureEdit1.TabIndex = 5;
            // 
            // FrmNufusCuzdani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 308);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.LblSoyad);
            this.Controls.Add(this.LblCinsiyet);
            this.Controls.Add(this.LblDogTar);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.LblTc);
            this.DoubleBuffered = true;
            this.Name = "FrmNufusCuzdani";
            this.Text = "FrmNufusCuzdani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblTc;
        private DevExpress.XtraEditors.LabelControl LblAd;
        private DevExpress.XtraEditors.LabelControl LblDogTar;
        private DevExpress.XtraEditors.LabelControl LblCinsiyet;
        private DevExpress.XtraEditors.LabelControl LblSoyad;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}