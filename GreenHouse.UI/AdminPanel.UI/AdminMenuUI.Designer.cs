
namespace GreenHouse.UI.AdminPanel.UI
{
    partial class AdminMenuUI
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
            this.components = new System.ComponentModel.Container();
            this.lstMenuler = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.BtnFiltreleriTemizle = new System.Windows.Forms.Button();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuAra = new System.Windows.Forms.Button();
            this.btnMenuGuncelle = new System.Windows.Forms.Button();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIconYolu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnElemanGuncelle = new System.Windows.Forms.Button();
            this.txtElemanLinkAdresi = new System.Windows.Forms.TextBox();
            this.btnElemanEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtElemanSirasi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chElemanAktifMi = new System.Windows.Forms.CheckBox();
            this.chSilinenElemanlariGoster = new System.Windows.Forms.CheckBox();
            this.lstElemanlar = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.elemanSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtElemanAdi = new System.Windows.Forms.TextBox();
            this.btnElemanAra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMenu = new System.Windows.Forms.TabPage();
            this.tpEleman = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.grpMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpMenu.SuspendLayout();
            this.tpEleman.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMenuler
            // 
            this.lstMenuler.ContextMenuStrip = this.contextMenuStrip1;
            this.lstMenuler.FormattingEnabled = true;
            this.lstMenuler.Location = new System.Drawing.Point(0, 16);
            this.lstMenuler.Name = "lstMenuler";
            this.lstMenuler.Size = new System.Drawing.Size(156, 303);
            this.lstMenuler.TabIndex = 0;
            this.lstMenuler.SelectedIndexChanged += new System.EventHandler(this.lstMenuler_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // menuSilToolStripMenuItem
            // 
            this.menuSilToolStripMenuItem.Name = "menuSilToolStripMenuItem";
            this.menuSilToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.menuSilToolStripMenuItem.Text = "MenuSil";
            this.menuSilToolStripMenuItem.Click += new System.EventHandler(this.menuSilToolStripMenuItem_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.grpMenu.Controls.Add(this.BtnFiltreleriTemizle);
            this.grpMenu.Controls.Add(this.txtMenuAdi);
            this.grpMenu.Controls.Add(this.label1);
            this.grpMenu.Controls.Add(this.lstMenuler);
            this.grpMenu.Controls.Add(this.btnMenuAra);
            this.grpMenu.Controls.Add(this.btnMenuGuncelle);
            this.grpMenu.Controls.Add(this.btnMenuEkle);
            this.grpMenu.Location = new System.Drawing.Point(3, 9);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(356, 319);
            this.grpMenu.TabIndex = 1;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menu";
            // 
            // BtnFiltreleriTemizle
            // 
            this.BtnFiltreleriTemizle.Location = new System.Drawing.Point(325, 102);
            this.BtnFiltreleriTemizle.Name = "BtnFiltreleriTemizle";
            this.BtnFiltreleriTemizle.Size = new System.Drawing.Size(25, 23);
            this.BtnFiltreleriTemizle.TabIndex = 27;
            this.BtnFiltreleriTemizle.Text = "O";
            this.BtnFiltreleriTemizle.UseVisualStyleBackColor = true;
            this.BtnFiltreleriTemizle.Click += new System.EventHandler(this.BtnFiltreleriTemizle_Click);
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(218, 131);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(132, 20);
            this.txtMenuAdi.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Adı :";
            // 
            // btnMenuAra
            // 
            this.btnMenuAra.Location = new System.Drawing.Point(282, 102);
            this.btnMenuAra.Name = "btnMenuAra";
            this.btnMenuAra.Size = new System.Drawing.Size(37, 23);
            this.btnMenuAra.TabIndex = 10;
            this.btnMenuAra.Text = "Ara";
            this.btnMenuAra.UseVisualStyleBackColor = true;
            this.btnMenuAra.Click += new System.EventHandler(this.btnMenuAra_Click);
            // 
            // btnMenuGuncelle
            // 
            this.btnMenuGuncelle.Location = new System.Drawing.Point(275, 176);
            this.btnMenuGuncelle.Name = "btnMenuGuncelle";
            this.btnMenuGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnMenuGuncelle.TabIndex = 12;
            this.btnMenuGuncelle.Text = "Guncelle";
            this.btnMenuGuncelle.UseVisualStyleBackColor = true;
            this.btnMenuGuncelle.Click += new System.EventHandler(this.btnMenuGuncelle_Click);
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.Location = new System.Drawing.Point(194, 176);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(75, 23);
            this.btnMenuEkle.TabIndex = 11;
            this.btnMenuEkle.Text = "Ekle";
            this.btnMenuEkle.UseVisualStyleBackColor = true;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.groupBox1.Controls.Add(this.txtIconYolu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnElemanGuncelle);
            this.groupBox1.Controls.Add(this.txtElemanLinkAdresi);
            this.groupBox1.Controls.Add(this.btnElemanEkle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtElemanSirasi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chElemanAktifMi);
            this.groupBox1.Controls.Add(this.chSilinenElemanlariGoster);
            this.groupBox1.Controls.Add(this.lstElemanlar);
            this.groupBox1.Controls.Add(this.txtElemanAdi);
            this.groupBox1.Controls.Add(this.btnElemanAra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(0, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 319);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eleman";
            // 
            // txtIconYolu
            // 
            this.txtIconYolu.Location = new System.Drawing.Point(218, 194);
            this.txtIconYolu.Name = "txtIconYolu";
            this.txtIconYolu.Size = new System.Drawing.Size(132, 20);
            this.txtIconYolu.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Icon :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "O";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnElemanGuncelle
            // 
            this.btnElemanGuncelle.Location = new System.Drawing.Point(282, 256);
            this.btnElemanGuncelle.Name = "btnElemanGuncelle";
            this.btnElemanGuncelle.Size = new System.Drawing.Size(68, 23);
            this.btnElemanGuncelle.TabIndex = 26;
            this.btnElemanGuncelle.Text = "Guncelle";
            this.btnElemanGuncelle.UseVisualStyleBackColor = true;
            this.btnElemanGuncelle.Click += new System.EventHandler(this.btnElemanGuncelle_Click);
            // 
            // txtElemanLinkAdresi
            // 
            this.txtElemanLinkAdresi.Location = new System.Drawing.Point(218, 168);
            this.txtElemanLinkAdresi.Name = "txtElemanLinkAdresi";
            this.txtElemanLinkAdresi.Size = new System.Drawing.Size(132, 20);
            this.txtElemanLinkAdresi.TabIndex = 34;
            // 
            // btnElemanEkle
            // 
            this.btnElemanEkle.Location = new System.Drawing.Point(218, 256);
            this.btnElemanEkle.Name = "btnElemanEkle";
            this.btnElemanEkle.Size = new System.Drawing.Size(60, 23);
            this.btnElemanEkle.TabIndex = 25;
            this.btnElemanEkle.Text = "Ekle";
            this.btnElemanEkle.UseVisualStyleBackColor = true;
            this.btnElemanEkle.Click += new System.EventHandler(this.btnElemanEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Link :";
            // 
            // txtElemanSirasi
            // 
            this.txtElemanSirasi.Location = new System.Drawing.Point(218, 142);
            this.txtElemanSirasi.Name = "txtElemanSirasi";
            this.txtElemanSirasi.Size = new System.Drawing.Size(132, 20);
            this.txtElemanSirasi.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sırası :";
            // 
            // chElemanAktifMi
            // 
            this.chElemanAktifMi.AutoSize = true;
            this.chElemanAktifMi.Location = new System.Drawing.Point(218, 223);
            this.chElemanAktifMi.Name = "chElemanAktifMi";
            this.chElemanAktifMi.Size = new System.Drawing.Size(67, 17);
            this.chElemanAktifMi.TabIndex = 27;
            this.chElemanAktifMi.Text = "Aktif Mi?";
            this.chElemanAktifMi.UseVisualStyleBackColor = true;
            // 
            // chSilinenElemanlariGoster
            // 
            this.chSilinenElemanlariGoster.AutoSize = true;
            this.chSilinenElemanlariGoster.Location = new System.Drawing.Point(0, 32);
            this.chSilinenElemanlariGoster.Name = "chSilinenElemanlariGoster";
            this.chSilinenElemanlariGoster.Size = new System.Drawing.Size(104, 17);
            this.chSilinenElemanlariGoster.TabIndex = 25;
            this.chSilinenElemanlariGoster.Text = "Silinenleri Göster";
            this.chSilinenElemanlariGoster.UseVisualStyleBackColor = true;
            this.chSilinenElemanlariGoster.CheckedChanged += new System.EventHandler(this.chSilinenElemanlariGoster_CheckedChanged);
            // 
            // lstElemanlar
            // 
            this.lstElemanlar.ContextMenuStrip = this.contextMenuStrip2;
            this.lstElemanlar.FormattingEnabled = true;
            this.lstElemanlar.Location = new System.Drawing.Point(0, 55);
            this.lstElemanlar.Name = "lstElemanlar";
            this.lstElemanlar.Size = new System.Drawing.Size(156, 264);
            this.lstElemanlar.TabIndex = 25;
            this.lstElemanlar.SelectedIndexChanged += new System.EventHandler(this.lstElemanlar_SelectedIndexChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elemanSilToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(126, 26);
            // 
            // elemanSilToolStripMenuItem
            // 
            this.elemanSilToolStripMenuItem.Name = "elemanSilToolStripMenuItem";
            this.elemanSilToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.elemanSilToolStripMenuItem.Text = "ElemanSil";
            this.elemanSilToolStripMenuItem.Click += new System.EventHandler(this.elemanSilToolStripMenuItem_Click);
            // 
            // txtElemanAdi
            // 
            this.txtElemanAdi.Location = new System.Drawing.Point(218, 113);
            this.txtElemanAdi.Name = "txtElemanAdi";
            this.txtElemanAdi.Size = new System.Drawing.Size(132, 20);
            this.txtElemanAdi.TabIndex = 28;
            // 
            // btnElemanAra
            // 
            this.btnElemanAra.Location = new System.Drawing.Point(282, 84);
            this.btnElemanAra.Name = "btnElemanAra";
            this.btnElemanAra.Size = new System.Drawing.Size(37, 23);
            this.btnElemanAra.TabIndex = 25;
            this.btnElemanAra.Text = "Ara";
            this.btnElemanAra.UseVisualStyleBackColor = true;
            this.btnElemanAra.Click += new System.EventHandler(this.btnElemanAra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Adı :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMenu);
            this.tabControl1.Controls.Add(this.tpEleman);
            this.tabControl1.Location = new System.Drawing.Point(163, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 364);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpMenu
            // 
            this.tpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.tpMenu.Controls.Add(this.grpMenu);
            this.tpMenu.Location = new System.Drawing.Point(4, 22);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenu.Size = new System.Drawing.Size(362, 338);
            this.tpMenu.TabIndex = 0;
            this.tpMenu.Text = "Menu";
            // 
            // tpEleman
            // 
            this.tpEleman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.tpEleman.Controls.Add(this.groupBox1);
            this.tpEleman.Location = new System.Drawing.Point(4, 22);
            this.tpEleman.Name = "tpEleman";
            this.tpEleman.Padding = new System.Windows.Forms.Padding(3);
            this.tpEleman.Size = new System.Drawing.Size(362, 338);
            this.tpEleman.TabIndex = 1;
            this.tpEleman.Text = "Eleman";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::GreenHouse.UI.Properties.Resources.Ekran_görüntüsü_2023_11_10_011157;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(630, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 27);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenuUI";
            this.Text = "AdminMenuUI";
            this.Load += new System.EventHandler(this.AdminMenuUI_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpMenu.ResumeLayout(false);
            this.tpEleman.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMenuler;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuAra;
        private System.Windows.Forms.Button btnMenuGuncelle;
        private System.Windows.Forms.Button btnMenuEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chElemanAktifMi;
        private System.Windows.Forms.CheckBox chSilinenElemanlariGoster;
        private System.Windows.Forms.ListBox lstElemanlar;
        private System.Windows.Forms.TextBox txtElemanAdi;
        private System.Windows.Forms.Button btnElemanAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnElemanGuncelle;
        private System.Windows.Forms.TextBox txtElemanLinkAdresi;
        private System.Windows.Forms.Button btnElemanEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtElemanSirasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSilToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem elemanSilToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMenu;
        private System.Windows.Forms.TabPage tpEleman;
        private System.Windows.Forms.Button BtnFiltreleriTemizle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIconYolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}