using System;

namespace OgrencıSıstemı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BTNAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.BTNOgretmenler = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.BTNOgrenciler = new DevExpress.XtraBars.BarButtonItem();
            this.BTNNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.BTNGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.BTNKasa = new DevExpress.XtraBars.BarButtonItem();
            this.BTNNotgiris = new DevExpress.XtraBars.BarButtonItem();
            this.BTNAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BTNAnasayfa,
            this.BTNOgretmenler,
            this.BTNOgrenciler,
            this.BTNNotlar,
            this.BTNGiderler,
            this.BTNKasa,
            this.BTNNotgiris,
            this.BTNAyarlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(984, 150);
            // 
            // BTNAnasayfa
            // 
            this.BTNAnasayfa.Caption = "ANA SAYFA";
            this.BTNAnasayfa.Id = 1;
            this.BTNAnasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNAnasayfa.ImageOptions.LargeImage")));
            this.BTNAnasayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNAnasayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.BTNAnasayfa.Name = "BTNAnasayfa";
            this.BTNAnasayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BTNAnasayfa_ItemClick);
            // 
            // BTNOgretmenler
            // 
            this.BTNOgretmenler.ActAsDropDown = true;
            this.BTNOgretmenler.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.BTNOgretmenler.Caption = "ÖĞRETMENLER";
            this.BTNOgretmenler.CloseRadialMenuOnItemClick = true;
            this.BTNOgretmenler.DropDownControl = this.popupMenu1;
            this.BTNOgretmenler.Id = 2;
            this.BTNOgretmenler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNOgretmenler.ImageOptions.LargeImage")));
            this.BTNOgretmenler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNOgretmenler.ItemAppearance.Normal.Options.UseFont = true;
            this.BTNOgretmenler.Name = "BTNOgretmenler";
            this.BTNOgretmenler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BTNOgretmenler_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // BTNOgrenciler
            // 
            this.BTNOgrenciler.Caption = "ÖĞRENCİLER";
            this.BTNOgrenciler.Id = 3;
            this.BTNOgrenciler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNOgrenciler.ImageOptions.LargeImage")));
            this.BTNOgrenciler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNOgrenciler.ItemAppearance.Normal.Options.UseFont = true;
            this.BTNOgrenciler.Name = "BTNOgrenciler";
            this.BTNOgrenciler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BTNOgrenciler_ItemClick_1);
            // 
            // BTNNotlar
            // 
            this.BTNNotlar.Caption = "NOTLAR";
            this.BTNNotlar.Id = 4;
            this.BTNNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNNotlar.ImageOptions.LargeImage")));
            this.BTNNotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNNotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BTNNotlar.Name = "BTNNotlar";
            // 
            // BTNGiderler
            // 
            this.BTNGiderler.Caption = "GİDERLER";
            this.BTNGiderler.Id = 5;
            this.BTNGiderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNGiderler.ImageOptions.LargeImage")));
            this.BTNGiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNGiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.BTNGiderler.Name = "BTNGiderler";
            // 
            // BTNKasa
            // 
            this.BTNKasa.Caption = "KASA";
            this.BTNKasa.Id = 6;
            this.BTNKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNKasa.ImageOptions.LargeImage")));
            this.BTNKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.BTNKasa.Name = "BTNKasa";
            // 
            // BTNNotgiris
            // 
            this.BTNNotgiris.Caption = "NOT GİRİŞ";
            this.BTNNotgiris.Id = 7;
            this.BTNNotgiris.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNNotgiris.ImageOptions.LargeImage")));
            this.BTNNotgiris.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNNotgiris.ItemAppearance.Normal.Options.UseFont = true;
            this.BTNNotgiris.Name = "BTNNotgiris";
            // 
            // BTNAyarlar
            // 
            this.BTNAyarlar.Caption = "AYARLAR";
            this.BTNAyarlar.Id = 8;
            this.BTNAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNAyarlar.ImageOptions.LargeImage")));
            this.BTNAyarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BTNAyarlar.Name = "BTNAyarlar";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "OKUL YÖNETİM SİSTEMİ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNAnasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNOgretmenler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNOgrenciler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNGiderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNNotgiris);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNAyarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.ribbonControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "A ÜNİVERSİTESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Add initialization code here
            // Example: Initialize controls, load data, etc.
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BTNAnasayfa;
        private DevExpress.XtraBars.BarButtonItem BTNOgretmenler;
        private DevExpress.XtraBars.BarButtonItem BTNOgrenciler;
        private DevExpress.XtraBars.BarButtonItem BTNNotlar;
        private DevExpress.XtraBars.BarButtonItem BTNGiderler;
        private DevExpress.XtraBars.BarButtonItem BTNKasa;
        private DevExpress.XtraBars.BarButtonItem BTNNotgiris;
        private DevExpress.XtraBars.BarButtonItem BTNAyarlar;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}

