
namespace GreenHouse.UI.AdminPanel.UI
{
    partial class AdminFirmaUrunUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFirmalarFU = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUrunlerFU = new System.Windows.Forms.ComboBox();
            this.btnEkleFirmaUrun = new System.Windows.Forms.Button();
            this.lstFirmaUrunleri = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbAktifMi = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lstUrunFirmalari = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEkleUrunFirma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUrunlerUF = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFirmalarUF = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFirmaUrun = new System.Windows.Forms.TabPage();
            this.tpUrunFirma = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpFirmaUrun.SuspendLayout();
            this.tpUrunFirma.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Firma Adı :";
            // 
            // cmbFirmalarFU
            // 
            this.cmbFirmalarFU.FormattingEnabled = true;
            this.cmbFirmalarFU.Location = new System.Drawing.Point(156, 7);
            this.cmbFirmalarFU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFirmalarFU.Name = "cmbFirmalarFU";
            this.cmbFirmalarFU.Size = new System.Drawing.Size(269, 24);
            this.cmbFirmalarFU.TabIndex = 7;
            this.cmbFirmalarFU.SelectedIndexChanged += new System.EventHandler(this.cmbFirmalarFU_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün Adı :";
            // 
            // cmbUrunlerFU
            // 
            this.cmbUrunlerFU.FormattingEnabled = true;
            this.cmbUrunlerFU.Location = new System.Drawing.Point(156, 41);
            this.cmbUrunlerFU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUrunlerFU.Name = "cmbUrunlerFU";
            this.cmbUrunlerFU.Size = new System.Drawing.Size(269, 24);
            this.cmbUrunlerFU.TabIndex = 9;
            // 
            // btnEkleFirmaUrun
            // 
            this.btnEkleFirmaUrun.Location = new System.Drawing.Point(347, 102);
            this.btnEkleFirmaUrun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkleFirmaUrun.Name = "btnEkleFirmaUrun";
            this.btnEkleFirmaUrun.Size = new System.Drawing.Size(80, 50);
            this.btnEkleFirmaUrun.TabIndex = 27;
            this.btnEkleFirmaUrun.Text = "Ekle";
            this.btnEkleFirmaUrun.UseVisualStyleBackColor = true;
            this.btnEkleFirmaUrun.Click += new System.EventHandler(this.btnEkleFirmaUrun_Click);
            // 
            // lstFirmaUrunleri
            // 
            this.lstFirmaUrunleri.ContextMenuStrip = this.contextMenuStrip1;
            this.lstFirmaUrunleri.FormattingEnabled = true;
            this.lstFirmaUrunleri.ItemHeight = 16;
            this.lstFirmaUrunleri.Location = new System.Drawing.Point(9, 160);
            this.lstFirmaUrunleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstFirmaUrunleri.Name = "lstFirmaUrunleri";
            this.lstFirmaUrunleri.Size = new System.Drawing.Size(416, 276);
            this.lstFirmaUrunleri.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // cbAktifMi
            // 
            this.cbAktifMi.AutoSize = true;
            this.cbAktifMi.Checked = true;
            this.cbAktifMi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAktifMi.Location = new System.Drawing.Point(337, 74);
            this.cbAktifMi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAktifMi.Name = "cbAktifMi";
            this.cbAktifMi.Size = new System.Drawing.Size(78, 20);
            this.cbAktifMi.TabIndex = 31;
            this.cbAktifMi.Text = "Aktif Mi?";
            this.cbAktifMi.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(340, 74);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 20);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "Aktif Mi?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lstUrunFirmalari
            // 
            this.lstUrunFirmalari.ContextMenuStrip = this.contextMenuStrip2;
            this.lstUrunFirmalari.FormattingEnabled = true;
            this.lstUrunFirmalari.ItemHeight = 16;
            this.lstUrunFirmalari.Location = new System.Drawing.Point(12, 160);
            this.lstUrunFirmalari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstUrunFirmalari.Name = "lstUrunFirmalari";
            this.lstUrunFirmalari.Size = new System.Drawing.Size(416, 276);
            this.lstUrunFirmalari.TabIndex = 38;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // btnEkleUrunFirma
            // 
            this.btnEkleUrunFirma.Location = new System.Drawing.Point(349, 102);
            this.btnEkleUrunFirma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkleUrunFirma.Name = "btnEkleUrunFirma";
            this.btnEkleUrunFirma.Size = new System.Drawing.Size(80, 50);
            this.btnEkleUrunFirma.TabIndex = 36;
            this.btnEkleUrunFirma.Text = "Ekle";
            this.btnEkleUrunFirma.UseVisualStyleBackColor = true;
            this.btnEkleUrunFirma.Click += new System.EventHandler(this.btnEkleUrunFirma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ürün Adı :";
            // 
            // cmbUrunlerUF
            // 
            this.cmbUrunlerUF.FormattingEnabled = true;
            this.cmbUrunlerUF.Location = new System.Drawing.Point(159, 7);
            this.cmbUrunlerUF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUrunlerUF.Name = "cmbUrunlerUF";
            this.cmbUrunlerUF.Size = new System.Drawing.Size(269, 24);
            this.cmbUrunlerUF.TabIndex = 34;
            this.cmbUrunlerUF.SelectedIndexChanged += new System.EventHandler(this.cmbUrunlerUF_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "Firma Adı :";
            // 
            // cmbFirmalarUF
            // 
            this.cmbFirmalarUF.FormattingEnabled = true;
            this.cmbFirmalarUF.Location = new System.Drawing.Point(159, 41);
            this.cmbFirmalarUF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFirmalarUF.Name = "cmbFirmalarUF";
            this.cmbFirmalarUF.Size = new System.Drawing.Size(269, 24);
            this.cmbFirmalarUF.TabIndex = 32;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFirmaUrun);
            this.tabControl1.Controls.Add(this.tpUrunFirma);
            this.tabControl1.Location = new System.Drawing.Point(243, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 495);
            this.tabControl1.TabIndex = 41;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpFirmaUrun
            // 
            this.tpFirmaUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.tpFirmaUrun.Controls.Add(this.label2);
            this.tpFirmaUrun.Controls.Add(this.cmbFirmalarFU);
            this.tpFirmaUrun.Controls.Add(this.cbAktifMi);
            this.tpFirmaUrun.Controls.Add(this.cmbUrunlerFU);
            this.tpFirmaUrun.Controls.Add(this.lstFirmaUrunleri);
            this.tpFirmaUrun.Controls.Add(this.label1);
            this.tpFirmaUrun.Controls.Add(this.btnEkleFirmaUrun);
            this.tpFirmaUrun.Location = new System.Drawing.Point(4, 25);
            this.tpFirmaUrun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpFirmaUrun.Name = "tpFirmaUrun";
            this.tpFirmaUrun.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpFirmaUrun.Size = new System.Drawing.Size(445, 466);
            this.tpFirmaUrun.TabIndex = 0;
            this.tpFirmaUrun.Text = "Firma-Urun";
            // 
            // tpUrunFirma
            // 
            this.tpUrunFirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.tpUrunFirma.Controls.Add(this.label4);
            this.tpUrunFirma.Controls.Add(this.label3);
            this.tpUrunFirma.Controls.Add(this.checkBox1);
            this.tpUrunFirma.Controls.Add(this.btnEkleUrunFirma);
            this.tpUrunFirma.Controls.Add(this.cmbFirmalarUF);
            this.tpUrunFirma.Controls.Add(this.lstUrunFirmalari);
            this.tpUrunFirma.Controls.Add(this.cmbUrunlerUF);
            this.tpUrunFirma.Location = new System.Drawing.Point(4, 25);
            this.tpUrunFirma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpUrunFirma.Name = "tpUrunFirma";
            this.tpUrunFirma.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpUrunFirma.Size = new System.Drawing.Size(445, 466);
            this.tpUrunFirma.TabIndex = 1;
            this.tpUrunFirma.Text = "Urun-Firma";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GreenHouse.UI.Properties.Resources.Ekran_görüntüsü_2023_11_10_011157;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(840, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 33);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminFirmaUrunUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(933, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminFirmaUrunUI";
            this.Text = "FirmaUrun";
            this.Load += new System.EventHandler(this.FirmaUrun_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpFirmaUrun.ResumeLayout(false);
            this.tpFirmaUrun.PerformLayout();
            this.tpUrunFirma.ResumeLayout(false);
            this.tpUrunFirma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFirmalarFU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUrunlerFU;
        private System.Windows.Forms.Button btnEkleFirmaUrun;
        private System.Windows.Forms.ListBox lstFirmaUrunleri;
        private System.Windows.Forms.CheckBox cbAktifMi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox lstUrunFirmalari;
        private System.Windows.Forms.Button btnEkleUrunFirma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUrunlerUF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFirmalarUF;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFirmaUrun;
        private System.Windows.Forms.TabPage tpUrunFirma;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}