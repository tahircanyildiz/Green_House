
namespace GreenHouse.UI.AdminPanel.UI
{
    partial class AdminUrunIcerikUI
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
            this.chAktifMiUB = new System.Windows.Forms.CheckBox();
            this.lstUrunBilesenleri = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEkleUrunBilesen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBilesenlerUB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunlerUB = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chAktifMiBU = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUrunlerBU = new System.Windows.Forms.ComboBox();
            this.lstBilesenUrunleri = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBilesenlerBU = new System.Windows.Forms.ComboBox();
            this.btnEkleBilesenUrun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chAktifMiUB
            // 
            this.chAktifMiUB.AutoSize = true;
            this.chAktifMiUB.Checked = true;
            this.chAktifMiUB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chAktifMiUB.Location = new System.Drawing.Point(268, 60);
            this.chAktifMiUB.Name = "chAktifMiUB";
            this.chAktifMiUB.Size = new System.Drawing.Size(67, 17);
            this.chAktifMiUB.TabIndex = 40;
            this.chAktifMiUB.Text = "Aktif Mi?";
            this.chAktifMiUB.UseVisualStyleBackColor = true;
            // 
            // lstUrunBilesenleri
            // 
            this.lstUrunBilesenleri.ContextMenuStrip = this.contextMenuStrip1;
            this.lstUrunBilesenleri.FormattingEnabled = true;
            this.lstUrunBilesenleri.Location = new System.Drawing.Point(22, 130);
            this.lstUrunBilesenleri.Name = "lstUrunBilesenleri";
            this.lstUrunBilesenleri.Size = new System.Drawing.Size(313, 225);
            this.lstUrunBilesenleri.TabIndex = 39;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btnEkleUrunBilesen
            // 
            this.btnEkleUrunBilesen.Location = new System.Drawing.Point(275, 83);
            this.btnEkleUrunBilesen.Name = "btnEkleUrunBilesen";
            this.btnEkleUrunBilesen.Size = new System.Drawing.Size(60, 41);
            this.btnEkleUrunBilesen.TabIndex = 36;
            this.btnEkleUrunBilesen.Text = "Ekle";
            this.btnEkleUrunBilesen.UseVisualStyleBackColor = true;
            this.btnEkleUrunBilesen.Click += new System.EventHandler(this.btnEkleUrunBilesen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ürün Adı :";
            // 
            // cmbBilesenlerUB
            // 
            this.cmbBilesenlerUB.FormattingEnabled = true;
            this.cmbBilesenlerUB.Location = new System.Drawing.Point(132, 33);
            this.cmbBilesenlerUB.Name = "cmbBilesenlerUB";
            this.cmbBilesenlerUB.Size = new System.Drawing.Size(203, 21);
            this.cmbBilesenlerUB.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Bileşen Adı :";
            // 
            // cmbUrunlerUB
            // 
            this.cmbUrunlerUB.FormattingEnabled = true;
            this.cmbUrunlerUB.Location = new System.Drawing.Point(132, 6);
            this.cmbUrunlerUB.Name = "cmbUrunlerUB";
            this.cmbUrunlerUB.Size = new System.Drawing.Size(203, 21);
            this.cmbUrunlerUB.TabIndex = 32;
            this.cmbUrunlerUB.SelectedIndexChanged += new System.EventHandler(this.cmbUrunlerUB_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(163, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(376, 391);
            this.tabControl1.TabIndex = 41;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chAktifMiUB);
            this.tabPage1.Controls.Add(this.cmbUrunlerUB);
            this.tabPage1.Controls.Add(this.lstUrunBilesenleri);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbBilesenlerUB);
            this.tabPage1.Controls.Add(this.btnEkleUrunBilesen);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(368, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Urun-Bilesen";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.tabPage2.Controls.Add(this.chAktifMiBU);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmbUrunlerBU);
            this.tabPage2.Controls.Add(this.lstBilesenUrunleri);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbBilesenlerBU);
            this.tabPage2.Controls.Add(this.btnEkleBilesenUrun);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(368, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bilesen-Urun";
            // 
            // chAktifMiBU
            // 
            this.chAktifMiBU.AutoSize = true;
            this.chAktifMiBU.Checked = true;
            this.chAktifMiBU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chAktifMiBU.Location = new System.Drawing.Point(270, 60);
            this.chAktifMiBU.Name = "chAktifMiBU";
            this.chAktifMiBU.Size = new System.Drawing.Size(67, 17);
            this.chAktifMiBU.TabIndex = 50;
            this.chAktifMiBU.Text = "Aktif Mi?";
            this.chAktifMiBU.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ürün Adı :";
            // 
            // cmbUrunlerBU
            // 
            this.cmbUrunlerBU.FormattingEnabled = true;
            this.cmbUrunlerBU.Location = new System.Drawing.Point(134, 33);
            this.cmbUrunlerBU.Name = "cmbUrunlerBU";
            this.cmbUrunlerBU.Size = new System.Drawing.Size(203, 21);
            this.cmbUrunlerBU.TabIndex = 42;
            // 
            // lstBilesenUrunleri
            // 
            this.lstBilesenUrunleri.ContextMenuStrip = this.contextMenuStrip2;
            this.lstBilesenUrunleri.FormattingEnabled = true;
            this.lstBilesenUrunleri.Location = new System.Drawing.Point(24, 130);
            this.lstBilesenUrunleri.Name = "lstBilesenUrunleri";
            this.lstBilesenUrunleri.Size = new System.Drawing.Size(313, 225);
            this.lstBilesenUrunleri.TabIndex = 49;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Bileşen Adı :";
            // 
            // cmbBilesenlerBU
            // 
            this.cmbBilesenlerBU.FormattingEnabled = true;
            this.cmbBilesenlerBU.Location = new System.Drawing.Point(134, 6);
            this.cmbBilesenlerBU.Name = "cmbBilesenlerBU";
            this.cmbBilesenlerBU.Size = new System.Drawing.Size(203, 21);
            this.cmbBilesenlerBU.TabIndex = 44;
            this.cmbBilesenlerBU.SelectedIndexChanged += new System.EventHandler(this.cmbBilesenlerBU_SelectedIndexChanged);
            // 
            // btnEkleBilesenUrun
            // 
            this.btnEkleBilesenUrun.Location = new System.Drawing.Point(277, 83);
            this.btnEkleBilesenUrun.Name = "btnEkleBilesenUrun";
            this.btnEkleBilesenUrun.Size = new System.Drawing.Size(60, 41);
            this.btnEkleBilesenUrun.TabIndex = 46;
            this.btnEkleBilesenUrun.Text = "Ekle";
            this.btnEkleBilesenUrun.UseVisualStyleBackColor = true;
            this.btnEkleBilesenUrun.Click += new System.EventHandler(this.btnEkleBilesenUrun_Click);
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
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminUrunIcerikUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(700, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUrunIcerikUI";
            this.Text = "UrunIcerik";
            this.Load += new System.EventHandler(this.UrunIcerik_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chAktifMiUB;
        private System.Windows.Forms.ListBox lstUrunBilesenleri;
        private System.Windows.Forms.Button btnEkleUrunBilesen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBilesenlerUB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunlerUB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chAktifMiBU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUrunlerBU;
        private System.Windows.Forms.ListBox lstBilesenUrunleri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBilesenlerBU;
        private System.Windows.Forms.Button btnEkleBilesenUrun;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}