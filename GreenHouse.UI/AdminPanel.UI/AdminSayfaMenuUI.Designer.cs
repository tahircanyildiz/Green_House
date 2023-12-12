
namespace GreenHouse.UI.AdminPanel.UI
{
    partial class AdminSayfaMenuUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSayfaMenu = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSayfalarSM = new System.Windows.Forms.ComboBox();
            this.cmbMenulerSM = new System.Windows.Forms.ComboBox();
            this.lstSayfaMenuleri = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sayfaMenuSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkleSayfaMenu = new System.Windows.Forms.Button();
            this.tpMenuSayfa = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkleMenuSayfa = new System.Windows.Forms.Button();
            this.cmbSayfalarMS = new System.Windows.Forms.ComboBox();
            this.lstMenuSayfalari = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSayfaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbMenulerMS = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpSayfaMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tpMenuSayfa.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSayfaMenu);
            this.tabControl1.Controls.Add(this.tpMenuSayfa);
            this.tabControl1.Location = new System.Drawing.Point(184, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 395);
            this.tabControl1.TabIndex = 42;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpSayfaMenu
            // 
            this.tpSayfaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.tpSayfaMenu.Controls.Add(this.label2);
            this.tpSayfaMenu.Controls.Add(this.cmbSayfalarSM);
            this.tpSayfaMenu.Controls.Add(this.cmbMenulerSM);
            this.tpSayfaMenu.Controls.Add(this.lstSayfaMenuleri);
            this.tpSayfaMenu.Controls.Add(this.label1);
            this.tpSayfaMenu.Controls.Add(this.btnEkleSayfaMenu);
            this.tpSayfaMenu.Location = new System.Drawing.Point(4, 22);
            this.tpSayfaMenu.Name = "tpSayfaMenu";
            this.tpSayfaMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpSayfaMenu.Size = new System.Drawing.Size(331, 369);
            this.tpSayfaMenu.TabIndex = 0;
            this.tpSayfaMenu.Text = "Sayfa-Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sayfa Adı :";
            // 
            // cmbSayfalarSM
            // 
            this.cmbSayfalarSM.FormattingEnabled = true;
            this.cmbSayfalarSM.Location = new System.Drawing.Point(114, 21);
            this.cmbSayfalarSM.Name = "cmbSayfalarSM";
            this.cmbSayfalarSM.Size = new System.Drawing.Size(203, 21);
            this.cmbSayfalarSM.TabIndex = 7;
            this.cmbSayfalarSM.SelectedIndexChanged += new System.EventHandler(this.cmbSayfalarSM_SelectedIndexChanged);
            // 
            // cmbMenulerSM
            // 
            this.cmbMenulerSM.FormattingEnabled = true;
            this.cmbMenulerSM.Location = new System.Drawing.Point(114, 62);
            this.cmbMenulerSM.Name = "cmbMenulerSM";
            this.cmbMenulerSM.Size = new System.Drawing.Size(203, 21);
            this.cmbMenulerSM.TabIndex = 9;
            // 
            // lstSayfaMenuleri
            // 
            this.lstSayfaMenuleri.ContextMenuStrip = this.contextMenuStrip1;
            this.lstSayfaMenuleri.FormattingEnabled = true;
            this.lstSayfaMenuleri.Location = new System.Drawing.Point(10, 136);
            this.lstSayfaMenuleri.Name = "lstSayfaMenuleri";
            this.lstSayfaMenuleri.Size = new System.Drawing.Size(313, 225);
            this.lstSayfaMenuleri.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sayfaMenuSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // sayfaMenuSilToolStripMenuItem
            // 
            this.sayfaMenuSilToolStripMenuItem.Name = "sayfaMenuSilToolStripMenuItem";
            this.sayfaMenuSilToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sayfaMenuSilToolStripMenuItem.Text = "SayfaMenuSil";
            this.sayfaMenuSilToolStripMenuItem.Click += new System.EventHandler(this.sayfaMenuSilToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menu Adı :";
            // 
            // btnEkleSayfaMenu
            // 
            this.btnEkleSayfaMenu.Location = new System.Drawing.Point(257, 89);
            this.btnEkleSayfaMenu.Name = "btnEkleSayfaMenu";
            this.btnEkleSayfaMenu.Size = new System.Drawing.Size(60, 41);
            this.btnEkleSayfaMenu.TabIndex = 27;
            this.btnEkleSayfaMenu.Text = "Ekle";
            this.btnEkleSayfaMenu.UseVisualStyleBackColor = true;
            this.btnEkleSayfaMenu.Click += new System.EventHandler(this.btnEkleSayfaMenu_Click);
            // 
            // tpMenuSayfa
            // 
            this.tpMenuSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.tpMenuSayfa.Controls.Add(this.label4);
            this.tpMenuSayfa.Controls.Add(this.label3);
            this.tpMenuSayfa.Controls.Add(this.btnEkleMenuSayfa);
            this.tpMenuSayfa.Controls.Add(this.cmbSayfalarMS);
            this.tpMenuSayfa.Controls.Add(this.lstMenuSayfalari);
            this.tpMenuSayfa.Controls.Add(this.cmbMenulerMS);
            this.tpMenuSayfa.Location = new System.Drawing.Point(4, 22);
            this.tpMenuSayfa.Name = "tpMenuSayfa";
            this.tpMenuSayfa.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenuSayfa.Size = new System.Drawing.Size(331, 369);
            this.tpMenuSayfa.TabIndex = 1;
            this.tpMenuSayfa.Text = "Menu-Sayfa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sayfa Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Menu Adı :";
            // 
            // btnEkleMenuSayfa
            // 
            this.btnEkleMenuSayfa.Location = new System.Drawing.Point(256, 115);
            this.btnEkleMenuSayfa.Name = "btnEkleMenuSayfa";
            this.btnEkleMenuSayfa.Size = new System.Drawing.Size(60, 41);
            this.btnEkleMenuSayfa.TabIndex = 36;
            this.btnEkleMenuSayfa.Text = "Ekle";
            this.btnEkleMenuSayfa.UseVisualStyleBackColor = true;
            this.btnEkleMenuSayfa.Click += new System.EventHandler(this.btnEkleMenuSayfa_Click);
            // 
            // cmbSayfalarMS
            // 
            this.cmbSayfalarMS.FormattingEnabled = true;
            this.cmbSayfalarMS.Location = new System.Drawing.Point(113, 68);
            this.cmbSayfalarMS.Name = "cmbSayfalarMS";
            this.cmbSayfalarMS.Size = new System.Drawing.Size(203, 21);
            this.cmbSayfalarMS.TabIndex = 32;
            // 
            // lstMenuSayfalari
            // 
            this.lstMenuSayfalari.ContextMenuStrip = this.contextMenuStrip2;
            this.lstMenuSayfalari.FormattingEnabled = true;
            this.lstMenuSayfalari.Location = new System.Drawing.Point(3, 177);
            this.lstMenuSayfalari.Name = "lstMenuSayfalari";
            this.lstMenuSayfalari.Size = new System.Drawing.Size(313, 225);
            this.lstMenuSayfalari.TabIndex = 38;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSayfaSilToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(146, 26);
            // 
            // menuSayfaSilToolStripMenuItem
            // 
            this.menuSayfaSilToolStripMenuItem.Name = "menuSayfaSilToolStripMenuItem";
            this.menuSayfaSilToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.menuSayfaSilToolStripMenuItem.Text = "MenuSayfaSil";
            this.menuSayfaSilToolStripMenuItem.Click += new System.EventHandler(this.menuSayfaSilToolStripMenuItem_Click);
            // 
            // cmbMenulerMS
            // 
            this.cmbMenulerMS.FormattingEnabled = true;
            this.cmbMenulerMS.Location = new System.Drawing.Point(113, 32);
            this.cmbMenulerMS.Name = "cmbMenulerMS";
            this.cmbMenulerMS.Size = new System.Drawing.Size(203, 21);
            this.cmbMenulerMS.TabIndex = 34;
            this.cmbMenulerMS.SelectedIndexChanged += new System.EventHandler(this.cmbMenulerMS_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GreenHouse.UI.Properties.Resources.Ekran_görüntüsü_2023_11_10_011157;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(630, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 27);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminSayfaMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(700, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSayfaMenuUI";
            this.Text = "AdminSayfaMenuYetkiUI";
            this.Load += new System.EventHandler(this.AdminSayfaMenuYetkiUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpSayfaMenu.ResumeLayout(false);
            this.tpSayfaMenu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tpMenuSayfa.ResumeLayout(false);
            this.tpMenuSayfa.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSayfaMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSayfalarSM;
        private System.Windows.Forms.ComboBox cmbMenulerSM;
        private System.Windows.Forms.ListBox lstSayfaMenuleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkleSayfaMenu;
        private System.Windows.Forms.TabPage tpMenuSayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkleMenuSayfa;
        private System.Windows.Forms.ComboBox cmbSayfalarMS;
        private System.Windows.Forms.ListBox lstMenuSayfalari;
        private System.Windows.Forms.ComboBox cmbMenulerMS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sayfaMenuSilToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuSayfaSilToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}