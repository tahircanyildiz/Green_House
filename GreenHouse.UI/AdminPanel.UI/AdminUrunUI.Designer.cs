
namespace GreenHouse.UI.AdminPanel.UI
{
    partial class AdminUrunUI
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUretiliyorMu = new System.Windows.Forms.CheckBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnFirmaSec = new System.Windows.Forms.Button();
            this.lblSecilenFirmaSayisi = new System.Windows.Forms.Label();
            this.lblSecilenBilesenSayisi = new System.Windows.Forms.Label();
            this.btnBilesenSec = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.btnDigerResimler = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOnYuzSayisi = new System.Windows.Forms.Label();
            this.lblResimSayisi = new System.Windows.Forms.Label();
            this.lblToplamUrunSayisi = new System.Windows.Forms.Label();
            this.chSilinenleriGoster = new System.Windows.Forms.CheckBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.ContextMenuStrip = this.contextMenuStrip1;
            this.lstUrunler.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 16;
            this.lstUrunler.Location = new System.Drawing.Point(0, 0);
            this.lstUrunler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(223, 569);
            this.lstUrunler.TabIndex = 4;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            this.lstUrunler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstUrunler_MouseDoubleClick);
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
            // cmbKategoriler
            // 
            this.cmbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(424, 140);
            this.cmbKategoriler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(252, 24);
            this.cmbKategoriler.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kategoriler :";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(424, 106);
            this.txtBarkodNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(252, 22);
            this.txtBarkodNo.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Barkod No :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuncelle.Location = new System.Drawing.Point(563, 475);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(115, 36);
            this.btnGuncelle.TabIndex = 26;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Yellow;
            this.btnEkle.Location = new System.Drawing.Point(424, 475);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(115, 36);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(424, 63);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(252, 22);
            this.txtUrunAdi.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ürün Adı :";
            // 
            // cbUretiliyorMu
            // 
            this.cbUretiliyorMu.AutoSize = true;
            this.cbUretiliyorMu.Checked = true;
            this.cbUretiliyorMu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUretiliyorMu.Location = new System.Drawing.Point(424, 271);
            this.cbUretiliyorMu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUretiliyorMu.Name = "cbUretiliyorMu";
            this.cbUretiliyorMu.Size = new System.Drawing.Size(83, 21);
            this.cbUretiliyorMu.TabIndex = 17;
            this.cbUretiliyorMu.Text = "Aktif mi?";
            this.cbUretiliyorMu.UseVisualStyleBackColor = true;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(424, 177);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(252, 86);
            this.txtAciklama.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Açıklama :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Firma :";
            // 
            // btnFirmaSec
            // 
            this.btnFirmaSec.Location = new System.Drawing.Point(424, 299);
            this.btnFirmaSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirmaSec.Name = "btnFirmaSec";
            this.btnFirmaSec.Size = new System.Drawing.Size(253, 28);
            this.btnFirmaSec.TabIndex = 33;
            this.btnFirmaSec.Text = "Firma Seç";
            this.btnFirmaSec.UseVisualStyleBackColor = true;
            this.btnFirmaSec.Click += new System.EventHandler(this.btnFirmaSec_Click);
            // 
            // lblSecilenFirmaSayisi
            // 
            this.lblSecilenFirmaSayisi.AutoSize = true;
            this.lblSecilenFirmaSayisi.Location = new System.Drawing.Point(685, 305);
            this.lblSecilenFirmaSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecilenFirmaSayisi.Name = "lblSecilenFirmaSayisi";
            this.lblSecilenFirmaSayisi.Size = new System.Drawing.Size(30, 17);
            this.lblSecilenFirmaSayisi.TabIndex = 34;
            this.lblSecilenFirmaSayisi.Text = "(   )";
            // 
            // lblSecilenBilesenSayisi
            // 
            this.lblSecilenBilesenSayisi.AutoSize = true;
            this.lblSecilenBilesenSayisi.Location = new System.Drawing.Point(685, 341);
            this.lblSecilenBilesenSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecilenBilesenSayisi.Name = "lblSecilenBilesenSayisi";
            this.lblSecilenBilesenSayisi.Size = new System.Drawing.Size(30, 17);
            this.lblSecilenBilesenSayisi.TabIndex = 37;
            this.lblSecilenBilesenSayisi.Text = "(   )";
            // 
            // btnBilesenSec
            // 
            this.btnBilesenSec.Location = new System.Drawing.Point(424, 335);
            this.btnBilesenSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBilesenSec.Name = "btnBilesenSec";
            this.btnBilesenSec.Size = new System.Drawing.Size(253, 28);
            this.btnBilesenSec.TabIndex = 36;
            this.btnBilesenSec.Text = "Bileşen Seç";
            this.btnBilesenSec.UseVisualStyleBackColor = true;
            this.btnBilesenSec.Click += new System.EventHandler(this.btnBilesenSec_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 341);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Bileşen :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 377);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ön Yüz Resmi :";
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
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(424, 370);
            this.btnResimEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(253, 28);
            this.btnResimEkle.TabIndex = 41;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // btnDigerResimler
            // 
            this.btnDigerResimler.Location = new System.Drawing.Point(424, 406);
            this.btnDigerResimler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDigerResimler.Name = "btnDigerResimler";
            this.btnDigerResimler.Size = new System.Drawing.Size(253, 28);
            this.btnDigerResimler.TabIndex = 43;
            this.btnDigerResimler.Text = "Resim Ekle";
            this.btnDigerResimler.UseVisualStyleBackColor = true;
            this.btnDigerResimler.Click += new System.EventHandler(this.btnDigerResimler_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 412);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Diğer Resimler :";
            // 
            // lblOnYuzSayisi
            // 
            this.lblOnYuzSayisi.AutoSize = true;
            this.lblOnYuzSayisi.Location = new System.Drawing.Point(685, 377);
            this.lblOnYuzSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOnYuzSayisi.Name = "lblOnYuzSayisi";
            this.lblOnYuzSayisi.Size = new System.Drawing.Size(30, 17);
            this.lblOnYuzSayisi.TabIndex = 44;
            this.lblOnYuzSayisi.Text = "(   )";
            // 
            // lblResimSayisi
            // 
            this.lblResimSayisi.AutoSize = true;
            this.lblResimSayisi.Location = new System.Drawing.Point(685, 412);
            this.lblResimSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResimSayisi.Name = "lblResimSayisi";
            this.lblResimSayisi.Size = new System.Drawing.Size(30, 17);
            this.lblResimSayisi.TabIndex = 45;
            this.lblResimSayisi.Text = "(   )";
            // 
            // lblToplamUrunSayisi
            // 
            this.lblToplamUrunSayisi.AutoSize = true;
            this.lblToplamUrunSayisi.Location = new System.Drawing.Point(232, 495);
            this.lblToplamUrunSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamUrunSayisi.Name = "lblToplamUrunSayisi";
            this.lblToplamUrunSayisi.Size = new System.Drawing.Size(86, 17);
            this.lblToplamUrunSayisi.TabIndex = 46;
            this.lblToplamUrunSayisi.Text = "Ürün sayısı :";
            // 
            // chSilinenleriGoster
            // 
            this.chSilinenleriGoster.AutoSize = true;
            this.chSilinenleriGoster.Checked = true;
            this.chSilinenleriGoster.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chSilinenleriGoster.Location = new System.Drawing.Point(235, 27);
            this.chSilinenleriGoster.Margin = new System.Windows.Forms.Padding(4);
            this.chSilinenleriGoster.Name = "chSilinenleriGoster";
            this.chSilinenleriGoster.Size = new System.Drawing.Size(138, 21);
            this.chSilinenleriGoster.TabIndex = 47;
            this.chSilinenleriGoster.Text = "Silinenleri Göster";
            this.chSilinenleriGoster.UseVisualStyleBackColor = true;
            this.chSilinenleriGoster.CheckedChanged += new System.EventHandler(this.chSilinenleriGoster_CheckedChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTemizle.Location = new System.Drawing.Point(424, 15);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(254, 34);
            this.btnTemizle.TabIndex = 48;
            this.btnTemizle.Text = "Seçimleri Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // AdminUrunUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(933, 569);
            this.ControlBox = false;
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.chSilinenleriGoster);
            this.Controls.Add(this.lblToplamUrunSayisi);
            this.Controls.Add(this.lblResimSayisi);
            this.Controls.Add(this.lblOnYuzSayisi);
            this.Controls.Add(this.btnDigerResimler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSecilenBilesenSayisi);
            this.Controls.Add(this.btnBilesenSec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSecilenFirmaSayisi);
            this.Controls.Add(this.btnFirmaSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.cbUretiliyorMu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminUrunUI";
            this.Text = "Admin Ürün Paneli";
            this.Load += new System.EventHandler(this.Urun_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.CheckBox cbUretiliyorMu;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFirmaSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSecilenFirmaSayisi;
        private System.Windows.Forms.Label lblSecilenBilesenSayisi;
        private System.Windows.Forms.Button btnBilesenSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.Button btnDigerResimler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResimSayisi;
        private System.Windows.Forms.Label lblOnYuzSayisi;
        private System.Windows.Forms.Label lblToplamUrunSayisi;
        private System.Windows.Forms.CheckBox chSilinenleriGoster;
        private System.Windows.Forms.Button btnTemizle;
    }
}