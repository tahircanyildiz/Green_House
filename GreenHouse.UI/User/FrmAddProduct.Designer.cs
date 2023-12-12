namespace GreenHouse.UI.UserUI
{
    partial class FrmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBarkod = new System.Windows.Forms.MaskedTextBox();
            this.txtBilesen = new System.Windows.Forms.RichTextBox();
            this.txtUrunAciklama = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResimSayisi = new System.Windows.Forms.Label();
            this.chcIsim = new System.Windows.Forms.CheckBox();
            this.lstUretici = new System.Windows.Forms.CheckedListBox();
            this.BtnUrunlerim = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnUrunAciklama = new System.Windows.Forms.Button();
            this.Btnİcerik = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnFrontProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.BtnSideMenu = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbBilesen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBilesenSayisi = new System.Windows.Forms.Label();
            this.BtnBilesenAciklama = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBilesenAciklama = new System.Windows.Forms.RichTextBox();
            this.BtnBilesen = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnResim = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(336, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ürün Ekle";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(153, 285);
            this.txtUrunAdi.Multiline = true;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(199, 28);
            this.txtUrunAdi.TabIndex = 15;
            // 
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.Color.Ivory;
            this.BtnSend.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.Location = new System.Drawing.Point(103, 523);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(571, 34);
            this.BtnSend.TabIndex = 17;
            this.BtnSend.Text = "Gönder";
            this.BtnSend.UseVisualStyleBackColor = false;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Barkod No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Üretici :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ürün Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Kategori :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(103, 89);
            this.txtBarkod.Mask = "000000000000000000000000000000";
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(250, 22);
            this.txtBarkod.TabIndex = 30;
            // 
            // txtBilesen
            // 
            this.txtBilesen.Location = new System.Drawing.Point(532, 92);
            this.txtBilesen.Name = "txtBilesen";
            this.txtBilesen.Size = new System.Drawing.Size(199, 30);
            this.txtBilesen.TabIndex = 31;
            this.txtBilesen.Text = "";
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(153, 378);
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(201, 81);
            this.txtUrunAciklama.TabIndex = 33;
            this.txtUrunAciklama.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(402, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Bilesen : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(9, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Urun Acikalama :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(150, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Resim Sayisi :";
            // 
            // lblResimSayisi
            // 
            this.lblResimSayisi.AutoSize = true;
            this.lblResimSayisi.Location = new System.Drawing.Point(258, 497);
            this.lblResimSayisi.Name = "lblResimSayisi";
            this.lblResimSayisi.Size = new System.Drawing.Size(14, 16);
            this.lblResimSayisi.TabIndex = 38;
            this.lblResimSayisi.Text = "0";
            // 
            // chcIsim
            // 
            this.chcIsim.AutoSize = true;
            this.chcIsim.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.chcIsim.Location = new System.Drawing.Point(152, 465);
            this.chcIsim.Name = "chcIsim";
            this.chcIsim.Size = new System.Drawing.Size(162, 20);
            this.chcIsim.TabIndex = 39;
            this.chcIsim.Text = "İsminiz gozuksun mu";
            this.chcIsim.UseVisualStyleBackColor = true;
            // 
            // lstUretici
            // 
            this.lstUretici.FormattingEnabled = true;
            this.lstUretici.Location = new System.Drawing.Point(103, 132);
            this.lstUretici.Name = "lstUretici";
            this.lstUretici.Size = new System.Drawing.Size(249, 140);
            this.lstUretici.TabIndex = 40;
            // 
            // BtnUrunlerim
            // 
            this.BtnUrunlerim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUrunlerim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUrunlerim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUrunlerim.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUrunlerim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUrunlerim.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BtnUrunlerim.FillColor2 = System.Drawing.Color.Black;
            this.BtnUrunlerim.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold);
            this.BtnUrunlerim.ForeColor = System.Drawing.Color.White;
            this.BtnUrunlerim.Location = new System.Drawing.Point(532, 438);
            this.BtnUrunlerim.Name = "BtnUrunlerim";
            this.BtnUrunlerim.Size = new System.Drawing.Size(121, 55);
            this.BtnUrunlerim.TabIndex = 41;
            this.BtnUrunlerim.Text = "Urunlerim";
            this.BtnUrunlerim.Click += new System.EventHandler(this.BtnUrunlerim_Click);
            // 
            // BtnUrunAciklama
            // 
            this.BtnUrunAciklama.BackgroundImage = global::GreenHouse.UI.Properties.Resources._1954554_hamburger_line_menu_more_buttton_three_icon;
            this.BtnUrunAciklama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUrunAciklama.Location = new System.Drawing.Point(358, 405);
            this.BtnUrunAciklama.Name = "BtnUrunAciklama";
            this.BtnUrunAciklama.Size = new System.Drawing.Size(30, 30);
            this.BtnUrunAciklama.TabIndex = 36;
            this.BtnUrunAciklama.UseVisualStyleBackColor = true;
            this.BtnUrunAciklama.Click += new System.EventHandler(this.BtnUrunAciklama_Click);
            // 
            // Btnİcerik
            // 
            this.Btnİcerik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btnİcerik.BackgroundImage")));
            this.Btnİcerik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btnİcerik.Location = new System.Drawing.Point(737, 95);
            this.Btnİcerik.Name = "Btnİcerik";
            this.Btnİcerik.Size = new System.Drawing.Size(30, 30);
            this.Btnİcerik.TabIndex = 32;
            this.Btnİcerik.UseVisualStyleBackColor = true;
            this.Btnİcerik.Click += new System.EventHandler(this.Btnİcerik_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(701, 511);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // BtnFrontProduct
            // 
            this.BtnFrontProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFrontProduct.BackgroundImage")));
            this.BtnFrontProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFrontProduct.Location = new System.Drawing.Point(339, 465);
            this.BtnFrontProduct.Name = "BtnFrontProduct";
            this.BtnFrontProduct.Size = new System.Drawing.Size(40, 38);
            this.BtnFrontProduct.TabIndex = 18;
            this.BtnFrontProduct.UseVisualStyleBackColor = true;
            this.BtnFrontProduct.Click += new System.EventHandler(this.BtnFrontProduct_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(359, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 35);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMainMenu.BackgroundImage")));
            this.BtnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMainMenu.Location = new System.Drawing.Point(12, 509);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(49, 48);
            this.BtnMainMenu.TabIndex = 10;
            this.BtnMainMenu.UseVisualStyleBackColor = false;
            // 
            // BtnProfile
            // 
            this.BtnProfile.BackColor = System.Drawing.SystemColors.Control;
            this.BtnProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnProfile.BackgroundImage")));
            this.BtnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnProfile.Location = new System.Drawing.Point(682, 19);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(49, 48);
            this.BtnProfile.TabIndex = 9;
            this.BtnProfile.UseVisualStyleBackColor = false;
            // 
            // BtnSideMenu
            // 
            this.BtnSideMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSideMenu.BackgroundImage")));
            this.BtnSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSideMenu.Location = new System.Drawing.Point(12, 19);
            this.BtnSideMenu.Name = "BtnSideMenu";
            this.BtnSideMenu.Size = new System.Drawing.Size(49, 48);
            this.BtnSideMenu.TabIndex = 8;
            this.BtnSideMenu.UseVisualStyleBackColor = false;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(153, 328);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(199, 24);
            this.cmbKategori.TabIndex = 42;
            // 
            // cmbBilesen
            // 
            this.cmbBilesen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBilesen.FormattingEnabled = true;
            this.cmbBilesen.Location = new System.Drawing.Point(532, 131);
            this.cmbBilesen.Name = "cmbBilesen";
            this.cmbBilesen.Size = new System.Drawing.Size(201, 24);
            this.cmbBilesen.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(370, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Mevcut Bilesen :";
            // 
            // lblBilesenSayisi
            // 
            this.lblBilesenSayisi.AutoSize = true;
            this.lblBilesenSayisi.Location = new System.Drawing.Point(501, 135);
            this.lblBilesenSayisi.Name = "lblBilesenSayisi";
            this.lblBilesenSayisi.Size = new System.Drawing.Size(14, 16);
            this.lblBilesenSayisi.TabIndex = 45;
            this.lblBilesenSayisi.Text = "0";
            this.lblBilesenSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBilesenAciklama
            // 
            this.BtnBilesenAciklama.BackgroundImage = global::GreenHouse.UI.Properties.Resources._1954554_hamburger_line_menu_more_buttton_three_icon;
            this.BtnBilesenAciklama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBilesenAciklama.Location = new System.Drawing.Point(737, 204);
            this.BtnBilesenAciklama.Name = "BtnBilesenAciklama";
            this.BtnBilesenAciklama.Size = new System.Drawing.Size(30, 30);
            this.BtnBilesenAciklama.TabIndex = 48;
            this.BtnBilesenAciklama.UseVisualStyleBackColor = true;
            this.BtnBilesenAciklama.Click += new System.EventHandler(this.BtnBilesenAciklama_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(370, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "Bilesen Acikalama :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBilesenAciklama
            // 
            this.txtBilesenAciklama.Location = new System.Drawing.Point(532, 177);
            this.txtBilesenAciklama.Name = "txtBilesenAciklama";
            this.txtBilesenAciklama.Size = new System.Drawing.Size(201, 81);
            this.txtBilesenAciklama.TabIndex = 46;
            this.txtBilesenAciklama.Text = "";
            // 
            // BtnBilesen
            // 
            this.BtnBilesen.BackColor = System.Drawing.Color.Transparent;
            this.BtnBilesen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBilesen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBilesen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBilesen.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBilesen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBilesen.FillColor = System.Drawing.Color.Yellow;
            this.BtnBilesen.FillColor2 = System.Drawing.Color.Black;
            this.BtnBilesen.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBilesen.ForeColor = System.Drawing.Color.White;
            this.BtnBilesen.Location = new System.Drawing.Point(532, 361);
            this.BtnBilesen.Name = "BtnBilesen";
            this.BtnBilesen.Size = new System.Drawing.Size(121, 57);
            this.BtnBilesen.TabIndex = 49;
            this.BtnBilesen.Text = "Bilesenler";
            this.BtnBilesen.UseTransparentBackground = true;
            this.BtnBilesen.Click += new System.EventHandler(this.BtnBilesen_Click);
            // 
            // BtnResim
            // 
            this.BtnResim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnResim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnResim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnResim.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnResim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnResim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnResim.FillColor2 = System.Drawing.Color.Black;
            this.BtnResim.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold);
            this.BtnResim.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnResim.Location = new System.Drawing.Point(532, 286);
            this.BtnResim.Name = "BtnResim";
            this.BtnResim.Size = new System.Drawing.Size(121, 55);
            this.BtnResim.TabIndex = 50;
            this.BtnResim.Text = "Resimler";
            this.BtnResim.Click += new System.EventHandler(this.BtnResim_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button1.BackgroundImage")));
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Location = new System.Drawing.Point(737, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(32, 29);
            this.guna2Button1.TabIndex = 51;
            this.guna2Button1.Text = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 578);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.BtnResim);
            this.Controls.Add(this.BtnBilesen);
            this.Controls.Add(this.BtnBilesenAciklama);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBilesenAciklama);
            this.Controls.Add(this.lblBilesenSayisi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBilesen);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.BtnUrunlerim);
            this.Controls.Add(this.lstUretici);
            this.Controls.Add(this.chcIsim);
            this.Controls.Add(this.lblResimSayisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnUrunAciklama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUrunAciklama);
            this.Controls.Add(this.Btnİcerik);
            this.Controls.Add(this.txtBilesen);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnFrontProduct);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.BtnProfile);
            this.Controls.Add(this.BtnSideMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddProduct";
            this.Load += new System.EventHandler(this.FrmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button BtnSideMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnFrontProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox txtBarkod;
        private System.Windows.Forms.RichTextBox txtBilesen;
        private System.Windows.Forms.Button Btnİcerik;
        private System.Windows.Forms.RichTextBox txtUrunAciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnUrunAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResimSayisi;
        private System.Windows.Forms.CheckBox chcIsim;
        private System.Windows.Forms.CheckedListBox lstUretici;
        private Guna.UI2.WinForms.Guna2GradientButton BtnUrunlerim;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbBilesen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBilesenSayisi;
        private System.Windows.Forms.Button BtnBilesenAciklama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtBilesenAciklama;
        private Guna.UI2.WinForms.Guna2GradientButton BtnBilesen;
        private Guna.UI2.WinForms.Guna2GradientButton BtnResim;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}