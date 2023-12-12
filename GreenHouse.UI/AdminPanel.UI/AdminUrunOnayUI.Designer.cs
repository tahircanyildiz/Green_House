
namespace GreenHouse.UI.AdminPanel.UI
{
    partial class AdminUrunOnayUI
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
            this.lstUrunler = new System.Windows.Forms.ListView();
            this.sira = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.takipNumarasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kullaniciGozuksunMu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ekleyenKullaniciMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inceleyenKullaniciMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.onayDurumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incelemeZamani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTakipNo = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.btnDetayGoster = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.chIncelenenleriGoster = new System.Windows.Forms.CheckBox();
            this.btnReddet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sira,
            this.urunAdi,
            this.takipNumarasi,
            this.kullaniciGozuksunMu,
            this.ekleyenKullaniciMail,
            this.inceleyenKullaniciMail,
            this.onayDurumu,
            this.incelemeZamani,
            this.ID});
            this.lstUrunler.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstUrunler.FullRowSelect = true;
            this.lstUrunler.HideSelection = false;
            this.lstUrunler.Location = new System.Drawing.Point(0, 0);
            this.lstUrunler.MultiSelect = false;
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(906, 348);
            this.lstUrunler.TabIndex = 0;
            this.lstUrunler.UseCompatibleStateImageBehavior = false;
            this.lstUrunler.View = System.Windows.Forms.View.Details;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // sira
            // 
            this.sira.Text = "Sıra";
            this.sira.Width = 38;
            // 
            // urunAdi
            // 
            this.urunAdi.Text = "Urun Adi";
            this.urunAdi.Width = 111;
            // 
            // takipNumarasi
            // 
            this.takipNumarasi.Text = "Takip Numarası";
            this.takipNumarasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.takipNumarasi.Width = 97;
            // 
            // kullaniciGozuksunMu
            // 
            this.kullaniciGozuksunMu.Text = "Kullanıcı Görünme Durumu";
            this.kullaniciGozuksunMu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kullaniciGozuksunMu.Width = 141;
            // 
            // ekleyenKullaniciMail
            // 
            this.ekleyenKullaniciMail.Text = "Ekleyen Kullanıcı ";
            this.ekleyenKullaniciMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ekleyenKullaniciMail.Width = 114;
            // 
            // inceleyenKullaniciMail
            // 
            this.inceleyenKullaniciMail.Text = "İnceleyen Kullanici";
            this.inceleyenKullaniciMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inceleyenKullaniciMail.Width = 148;
            // 
            // onayDurumu
            // 
            this.onayDurumu.Text = "Onay Durumu";
            this.onayDurumu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.onayDurumu.Width = 120;
            // 
            // incelemeZamani
            // 
            this.incelemeZamani.Text = "İnceleme Zamanı";
            this.incelemeZamani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.incelemeZamani.Width = 130;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Takip Numarası :";
            // 
            // txtTakipNo
            // 
            this.txtTakipNo.Location = new System.Drawing.Point(105, 358);
            this.txtTakipNo.Name = "txtTakipNo";
            this.txtTakipNo.Size = new System.Drawing.Size(153, 20);
            this.txtTakipNo.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(264, 356);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(42, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(312, 355);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(25, 23);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "O";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(37, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Urun ID :";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(93, 385);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(244, 20);
            this.txtUrunID.TabIndex = 6;
            // 
            // btnDetayGoster
            // 
            this.btnDetayGoster.Location = new System.Drawing.Point(169, 411);
            this.btnDetayGoster.Name = "btnDetayGoster";
            this.btnDetayGoster.Size = new System.Drawing.Size(168, 23);
            this.btnDetayGoster.TabIndex = 7;
            this.btnDetayGoster.Text = "Detayları Göster";
            this.btnDetayGoster.UseVisualStyleBackColor = true;
            this.btnDetayGoster.Click += new System.EventHandler(this.btnDetayGoster_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(610, 361);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(127, 23);
            this.btnOnayla.TabIndex = 8;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // chIncelenenleriGoster
            // 
            this.chIncelenenleriGoster.AutoSize = true;
            this.chIncelenenleriGoster.BackColor = System.Drawing.Color.Transparent;
            this.chIncelenenleriGoster.Checked = true;
            this.chIncelenenleriGoster.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chIncelenenleriGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chIncelenenleriGoster.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chIncelenenleriGoster.Location = new System.Drawing.Point(353, 361);
            this.chIncelenenleriGoster.Name = "chIncelenenleriGoster";
            this.chIncelenenleriGoster.Size = new System.Drawing.Size(140, 17);
            this.chIncelenenleriGoster.TabIndex = 9;
            this.chIncelenenleriGoster.Text = "İncelenenleri Göster";
            this.chIncelenenleriGoster.UseVisualStyleBackColor = false;
            this.chIncelenenleriGoster.CheckedChanged += new System.EventHandler(this.chIncelenenleriGoster_CheckedChanged);
            // 
            // btnReddet
            // 
            this.btnReddet.Location = new System.Drawing.Point(743, 361);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(127, 23);
            this.btnReddet.TabIndex = 10;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.UseVisualStyleBackColor = true;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GreenHouse.UI.Properties.Resources.Ekran_görüntüsü_2023_11_10_011157;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(822, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 27);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminUrunOnayUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(906, 510);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.chIncelenenleriGoster);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.btnDetayGoster);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtTakipNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUrunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUrunOnayUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUrunOnayUI";
            this.Load += new System.EventHandler(this.AdminUrunOnayUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstUrunler;
        private System.Windows.Forms.ColumnHeader urunAdi;
        private System.Windows.Forms.ColumnHeader takipNumarasi;
        private System.Windows.Forms.ColumnHeader kullaniciGozuksunMu;
        private System.Windows.Forms.ColumnHeader ekleyenKullaniciMail;
        private System.Windows.Forms.ColumnHeader inceleyenKullaniciMail;
        private System.Windows.Forms.ColumnHeader onayDurumu;
        private System.Windows.Forms.ColumnHeader incelemeZamani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTakipNo;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Button btnDetayGoster;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.CheckBox chIncelenenleriGoster;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.ColumnHeader sira;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button button1;
    }
}