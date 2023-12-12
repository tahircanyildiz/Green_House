
namespace GreenHouse.UI.AdminPanel.UI
{
    partial class AdminKategoriUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdı = new System.Windows.Forms.TextBox();
            this.cbAnaKategoriMi = new System.Windows.Forms.CheckBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAktifMi = new System.Windows.Forms.CheckBox();
            this.lstKategoriler = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKategoriAra = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(283, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori Adı :";
            // 
            // txtKategoriAdı
            // 
            this.txtKategoriAdı.Location = new System.Drawing.Point(373, 112);
            this.txtKategoriAdı.Name = "txtKategoriAdı";
            this.txtKategoriAdı.Size = new System.Drawing.Size(203, 20);
            this.txtKategoriAdı.TabIndex = 2;
            // 
            // cbAnaKategoriMi
            // 
            this.cbAnaKategoriMi.AutoSize = true;
            this.cbAnaKategoriMi.BackColor = System.Drawing.Color.Transparent;
            this.cbAnaKategoriMi.Checked = true;
            this.cbAnaKategoriMi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAnaKategoriMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAnaKategoriMi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbAnaKategoriMi.Location = new System.Drawing.Point(453, 138);
            this.cbAnaKategoriMi.Name = "cbAnaKategoriMi";
            this.cbAnaKategoriMi.Size = new System.Drawing.Size(123, 17);
            this.cbAnaKategoriMi.TabIndex = 4;
            this.cbAnaKategoriMi.Text = "Ana Kategori Mi?";
            this.cbAnaKategoriMi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbAnaKategoriMi.UseVisualStyleBackColor = false;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(373, 170);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(203, 21);
            this.cmbKategoriler.TabIndex = 5;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(260, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Üst Kategori Adı :";
            // 
            // cbAktifMi
            // 
            this.cbAktifMi.AutoSize = true;
            this.cbAktifMi.BackColor = System.Drawing.Color.Transparent;
            this.cbAktifMi.Checked = true;
            this.cbAktifMi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAktifMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAktifMi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbAktifMi.Location = new System.Drawing.Point(500, 197);
            this.cbAktifMi.Name = "cbAktifMi";
            this.cbAktifMi.Size = new System.Drawing.Size(76, 17);
            this.cbAktifMi.TabIndex = 10;
            this.cbAktifMi.Text = "Aktif Mi?";
            this.cbAktifMi.UseVisualStyleBackColor = false;
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.ContextMenuStrip = this.contextMenuStrip1;
            this.lstKategoriler.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.Location = new System.Drawing.Point(0, 0);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(202, 462);
            this.lstKategoriler.TabIndex = 11;
            this.lstKategoriler.SelectedIndexChanged += new System.EventHandler(this.lstKategoriler_SelectedIndexChanged);
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
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(516, 220);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(60, 24);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(373, 220);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(60, 24);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(208, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(60, 24);
            this.btnTemizle.TabIndex = 20;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKategoriAra
            // 
            this.btnKategoriAra.Location = new System.Drawing.Point(539, 83);
            this.btnKategoriAra.Name = "btnKategoriAra";
            this.btnKategoriAra.Size = new System.Drawing.Size(37, 23);
            this.btnKategoriAra.TabIndex = 60;
            this.btnKategoriAra.Text = "Ara";
            this.btnKategoriAra.UseVisualStyleBackColor = true;
            this.btnKategoriAra.Click += new System.EventHandler(this.btnKategoriAra_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GreenHouse.UI.Properties.Resources._1930258_green_info_information_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(490, 220);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GreenHouse.UI.Properties.Resources._1930258_green_info_information_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(373, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminKategoriUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 462);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKategoriAra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstKategoriler);
            this.Controls.Add(this.cbAktifMi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.cbAnaKategoriMi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKategoriAdı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminKategoriUI";
            this.Text = "Kategori";
            this.Load += new System.EventHandler(this.Kategori_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriAdı;
        private System.Windows.Forms.CheckBox cbAnaKategoriMi;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAktifMi;
        private System.Windows.Forms.ListBox lstKategoriler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKategoriAra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}