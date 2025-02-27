namespace OgrencıSıstemı
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnYonetici = new System.Windows.Forms.Button();
            this.BtnOgretmen = new System.Windows.Forms.Button();
            this.BtnOgrenci = new System.Windows.Forms.Button();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(143, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(690, 57);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "A ÜNİVERSİTESİ GİRİŞ PANELİ";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(701, 392);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Properties.Appearance.BackColor = System.Drawing.Color.Sienna;
            this.TxtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSifre.Properties.Appearance.Options.UseFont = true;
            this.TxtSifre.Properties.UseSystemPasswordChar = true;
            this.TxtSifre.Size = new System.Drawing.Size(128, 26);
            this.TxtSifre.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(162, 387);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 33);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Kullanıcı:";
            // 
            // MskTC
            // 
            this.MskTC.BackColor = System.Drawing.Color.SaddleBrown;
            this.MskTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.Location = new System.Drawing.Point(293, 394);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(145, 26);
            this.MskTC.TabIndex = 4;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(622, 387);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 33);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Şifre:";
            // 
            // BtnYonetici
            // 
            this.BtnYonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnYonetici.BackgroundImage")));
            this.BtnYonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnYonetici.Location = new System.Drawing.Point(220, 443);
            this.BtnYonetici.Name = "BtnYonetici";
            this.BtnYonetici.Size = new System.Drawing.Size(190, 105);
            this.BtnYonetici.TabIndex = 6;
            this.BtnYonetici.UseVisualStyleBackColor = true;
            // 
            // BtnOgretmen
            // 
            this.BtnOgretmen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOgretmen.BackgroundImage")));
            this.BtnOgretmen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOgretmen.Location = new System.Drawing.Point(417, 443);
            this.BtnOgretmen.Name = "BtnOgretmen";
            this.BtnOgretmen.Size = new System.Drawing.Size(190, 105);
            this.BtnOgretmen.TabIndex = 7;
            this.BtnOgretmen.UseVisualStyleBackColor = true;
            this.BtnOgretmen.Click += new System.EventHandler(this.FrmGiris_Load);
            // 
            // BtnOgrenci
            // 
            this.BtnOgrenci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOgrenci.BackgroundImage")));
            this.BtnOgrenci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOgrenci.Location = new System.Drawing.Point(613, 443);
            this.BtnOgrenci.Name = "BtnOgrenci";
            this.BtnOgrenci.Size = new System.Drawing.Size(190, 105);
            this.BtnOgrenci.TabIndex = 8;
            this.BtnOgrenci.UseVisualStyleBackColor = true;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Location = new System.Drawing.Point(484, 583);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(123, 41);
            this.BtnGiris.TabIndex = 9;
            this.BtnGiris.Text = "GİRİŞ";
            this.BtnGiris.UseVisualStyleBackColor = true;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 673);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.BtnOgrenci);
            this.Controls.Add(this.BtnOgretmen);
            this.Controls.Add(this.BtnYonetici);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button BtnYonetici;
        private System.Windows.Forms.Button BtnOgretmen;
        private System.Windows.Forms.Button BtnOgrenci;
        private System.Windows.Forms.Button BtnGiris;
    }
}