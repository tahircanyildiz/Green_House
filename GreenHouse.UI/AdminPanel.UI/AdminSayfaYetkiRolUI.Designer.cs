
namespace GreenHouse.UI.AdminPanel.UI
{
    partial class AdminSayfaYetkiRolUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSayfaYetkiRolUI));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Rol = new System.Windows.Forms.TabPage();
            this.chRolAktifMi = new System.Windows.Forms.CheckBox();
            this.chSilinenRolleriGoster = new System.Windows.Forms.CheckBox();
            this.btnRolGuncelle = new System.Windows.Forms.Button();
            this.btnRolEkle = new System.Windows.Forms.Button();
            this.txtRolAdi = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lstRol = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rolSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpSYR = new System.Windows.Forms.TabPage();
            this.btnSYRKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chlsYetkiler = new System.Windows.Forms.CheckedListBox();
            this.btnSRYEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYetkiler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSayfalar = new System.Windows.Forms.ComboBox();
            this.lstSYRoller = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.Rol.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tpSYR.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Rol);
            this.tabControl1.Controls.Add(this.tpSYR);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // Rol
            // 
            this.Rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Rol.Controls.Add(this.chRolAktifMi);
            this.Rol.Controls.Add(this.chSilinenRolleriGoster);
            this.Rol.Controls.Add(this.btnRolGuncelle);
            this.Rol.Controls.Add(this.btnRolEkle);
            this.Rol.Controls.Add(this.txtRolAdi);
            this.Rol.Controls.Add(this.lblRol);
            this.Rol.Controls.Add(this.lstRol);
            this.Rol.Location = new System.Drawing.Point(4, 25);
            this.Rol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rol.Name = "Rol";
            this.Rol.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rol.Size = new System.Drawing.Size(556, 511);
            this.Rol.TabIndex = 0;
            this.Rol.Text = "Rol";
            // 
            // chRolAktifMi
            // 
            this.chRolAktifMi.AutoSize = true;
            this.chRolAktifMi.Location = new System.Drawing.Point(339, 76);
            this.chRolAktifMi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chRolAktifMi.Name = "chRolAktifMi";
            this.chRolAktifMi.Size = new System.Drawing.Size(78, 20);
            this.chRolAktifMi.TabIndex = 6;
            this.chRolAktifMi.Text = "Aktif mi?";
            this.chRolAktifMi.UseVisualStyleBackColor = true;
            // 
            // chSilinenRolleriGoster
            // 
            this.chSilinenRolleriGoster.AutoSize = true;
            this.chSilinenRolleriGoster.Location = new System.Drawing.Point(9, 20);
            this.chSilinenRolleriGoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chSilinenRolleriGoster.Name = "chSilinenRolleriGoster";
            this.chSilinenRolleriGoster.Size = new System.Drawing.Size(130, 20);
            this.chSilinenRolleriGoster.TabIndex = 5;
            this.chSilinenRolleriGoster.Text = "Silinenleri Göster";
            this.chSilinenRolleriGoster.UseVisualStyleBackColor = true;
            this.chSilinenRolleriGoster.CheckedChanged += new System.EventHandler(this.chSilinenRolleriGoster_CheckedChanged);
            // 
            // btnRolGuncelle
            // 
            this.btnRolGuncelle.Location = new System.Drawing.Point(455, 105);
            this.btnRolGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRolGuncelle.Name = "btnRolGuncelle";
            this.btnRolGuncelle.Size = new System.Drawing.Size(89, 28);
            this.btnRolGuncelle.TabIndex = 4;
            this.btnRolGuncelle.Text = "Guncelle";
            this.btnRolGuncelle.UseVisualStyleBackColor = true;
            this.btnRolGuncelle.Click += new System.EventHandler(this.btnRolGuncelle_Click);
            // 
            // btnRolEkle
            // 
            this.btnRolEkle.Location = new System.Drawing.Point(339, 105);
            this.btnRolEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRolEkle.Name = "btnRolEkle";
            this.btnRolEkle.Size = new System.Drawing.Size(89, 28);
            this.btnRolEkle.TabIndex = 3;
            this.btnRolEkle.Text = "Ekle";
            this.btnRolEkle.UseVisualStyleBackColor = true;
            this.btnRolEkle.Click += new System.EventHandler(this.btnRolEkle_Click);
            // 
            // txtRolAdi
            // 
            this.txtRolAdi.Location = new System.Drawing.Point(339, 44);
            this.txtRolAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRolAdi.Name = "txtRolAdi";
            this.txtRolAdi.Size = new System.Drawing.Size(204, 22);
            this.txtRolAdi.TabIndex = 2;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(268, 48);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(57, 16);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol Adı :";
            // 
            // lstRol
            // 
            this.lstRol.ContextMenuStrip = this.contextMenuStrip1;
            this.lstRol.FormattingEnabled = true;
            this.lstRol.ItemHeight = 16;
            this.lstRol.Location = new System.Drawing.Point(8, 48);
            this.lstRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstRol.Name = "lstRol";
            this.lstRol.Size = new System.Drawing.Size(251, 404);
            this.lstRol.TabIndex = 0;
            this.lstRol.SelectedIndexChanged += new System.EventHandler(this.lstRol_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 28);
            // 
            // rolSilToolStripMenuItem
            // 
            this.rolSilToolStripMenuItem.Name = "rolSilToolStripMenuItem";
            this.rolSilToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.rolSilToolStripMenuItem.Text = "Rol Sil";
            this.rolSilToolStripMenuItem.Click += new System.EventHandler(this.rolSilToolStripMenuItem_Click);
            // 
            // tpSYR
            // 
            this.tpSYR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tpSYR.Controls.Add(this.btnSYRKaydet);
            this.tpSYR.Controls.Add(this.label2);
            this.tpSYR.Controls.Add(this.chlsYetkiler);
            this.tpSYR.Controls.Add(this.btnSRYEkle);
            this.tpSYR.Controls.Add(this.label3);
            this.tpSYR.Controls.Add(this.cmbYetkiler);
            this.tpSYR.Controls.Add(this.label1);
            this.tpSYR.Controls.Add(this.cmbSayfalar);
            this.tpSYR.Controls.Add(this.lstSYRoller);
            this.tpSYR.Location = new System.Drawing.Point(4, 25);
            this.tpSYR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpSYR.Name = "tpSYR";
            this.tpSYR.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpSYR.Size = new System.Drawing.Size(556, 511);
            this.tpSYR.TabIndex = 1;
            this.tpSYR.Text = "Sayfa-Yetki-Rol";
            // 
            // btnSYRKaydet
            // 
            this.btnSYRKaydet.Location = new System.Drawing.Point(425, 420);
            this.btnSYRKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSYRKaydet.Name = "btnSYRKaydet";
            this.btnSYRKaydet.Size = new System.Drawing.Size(100, 28);
            this.btnSYRKaydet.TabIndex = 12;
            this.btnSYRKaydet.Text = "Kaydet";
            this.btnSYRKaydet.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yetkiler";
            // 
            // chlsYetkiler
            // 
            this.chlsYetkiler.FormattingEnabled = true;
            this.chlsYetkiler.Location = new System.Drawing.Point(283, 222);
            this.chlsYetkiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chlsYetkiler.Name = "chlsYetkiler";
            this.chlsYetkiler.Size = new System.Drawing.Size(241, 174);
            this.chlsYetkiler.TabIndex = 10;
            // 
            // btnSRYEkle
            // 
            this.btnSRYEkle.Location = new System.Drawing.Point(425, 106);
            this.btnSRYEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSRYEkle.Name = "btnSRYEkle";
            this.btnSRYEkle.Size = new System.Drawing.Size(100, 28);
            this.btnSRYEkle.TabIndex = 8;
            this.btnSRYEkle.Text = "Ekle";
            this.btnSRYEkle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yetki Adı :";
            // 
            // cmbYetkiler
            // 
            this.cmbYetkiler.FormattingEnabled = true;
            this.cmbYetkiler.Location = new System.Drawing.Point(364, 73);
            this.cmbYetkiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbYetkiler.Name = "cmbYetkiler";
            this.cmbYetkiler.Size = new System.Drawing.Size(160, 24);
            this.cmbYetkiler.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sayfa Adı :";
            // 
            // cmbSayfalar
            // 
            this.cmbSayfalar.FormattingEnabled = true;
            this.cmbSayfalar.Location = new System.Drawing.Point(364, 39);
            this.cmbSayfalar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSayfalar.Name = "cmbSayfalar";
            this.cmbSayfalar.Size = new System.Drawing.Size(160, 24);
            this.cmbSayfalar.TabIndex = 2;
            this.cmbSayfalar.SelectedIndexChanged += new System.EventHandler(this.cmbSayfalar_SelectedIndexChanged);
            // 
            // lstSYRoller
            // 
            this.lstSYRoller.FormattingEnabled = true;
            this.lstSYRoller.ItemHeight = 16;
            this.lstSYRoller.Location = new System.Drawing.Point(8, 43);
            this.lstSYRoller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSYRoller.Name = "lstSYRoller";
            this.lstSYRoller.Size = new System.Drawing.Size(196, 404);
            this.lstSYRoller.TabIndex = 1;
            this.lstSYRoller.SelectedIndexChanged += new System.EventHandler(this.lstSYRoller_SelectedIndexChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // AdminSayfaYetkiRolUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(587, 550);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminSayfaYetkiRolUI";
            this.Text = "AdminSayfaYetkiRolUI";
            this.Load += new System.EventHandler(this.AdminSayfaYetkiRolUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.Rol.ResumeLayout(false);
            this.Rol.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tpSYR.ResumeLayout(false);
            this.tpSYR.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Rol;
        private System.Windows.Forms.Button btnRolGuncelle;
        private System.Windows.Forms.Button btnRolEkle;
        private System.Windows.Forms.TextBox txtRolAdi;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ListBox lstRol;
        private System.Windows.Forms.TabPage tpSYR;
        private System.Windows.Forms.CheckBox chRolAktifMi;
        private System.Windows.Forms.CheckBox chSilinenRolleriGoster;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rolSilToolStripMenuItem;
        private System.Windows.Forms.ListBox lstSYRoller;
        private System.Windows.Forms.Button btnSRYEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYetkiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSayfalar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chlsYetkiler;
        private System.Windows.Forms.Button btnSYRKaydet;
    }
}