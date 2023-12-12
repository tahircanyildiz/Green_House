
namespace GreenHouse.UI.AdminPanel.UI
{
    partial class AdminUserControlUI
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
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.grpUserBilgileri = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnUserAra = new System.Windows.Forms.Button();
            this.btnUserGuncelle = new System.Windows.Forms.Button();
            this.chUserAktifMi = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.chSilinenUserleriGoster = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.grpUserBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(0, 0);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(168, 462);
            this.lstUsers.TabIndex = 0;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı :";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(70, 107);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(132, 20);
            this.txtAdi.TabIndex = 3;
            // 
            // grpUserBilgileri
            // 
            this.grpUserBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.grpUserBilgileri.Controls.Add(this.btnTemizle);
            this.grpUserBilgileri.Controls.Add(this.btnUserAra);
            this.grpUserBilgileri.Controls.Add(this.btnUserGuncelle);
            this.grpUserBilgileri.Controls.Add(this.chUserAktifMi);
            this.grpUserBilgileri.Controls.Add(this.txtID);
            this.grpUserBilgileri.Controls.Add(this.label6);
            this.grpUserBilgileri.Controls.Add(this.label3);
            this.grpUserBilgileri.Controls.Add(this.txtAdi);
            this.grpUserBilgileri.Controls.Add(this.txtEmail);
            this.grpUserBilgileri.Controls.Add(this.label2);
            this.grpUserBilgileri.Controls.Add(this.txtSoyadi);
            this.grpUserBilgileri.Controls.Add(this.label1);
            this.grpUserBilgileri.Location = new System.Drawing.Point(295, 73);
            this.grpUserBilgileri.Name = "grpUserBilgileri";
            this.grpUserBilgileri.Size = new System.Drawing.Size(261, 301);
            this.grpUserBilgileri.TabIndex = 4;
            this.grpUserBilgileri.TabStop = false;
            this.grpUserBilgileri.Text = "User Bilgileri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(142, 230);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(60, 23);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnUserAra
            // 
            this.btnUserAra.Location = new System.Drawing.Point(165, 52);
            this.btnUserAra.Name = "btnUserAra";
            this.btnUserAra.Size = new System.Drawing.Size(37, 23);
            this.btnUserAra.TabIndex = 23;
            this.btnUserAra.Text = "Ara";
            this.btnUserAra.UseVisualStyleBackColor = true;
            this.btnUserAra.Click += new System.EventHandler(this.btnUserAra_Click);
            // 
            // btnUserGuncelle
            // 
            this.btnUserGuncelle.Location = new System.Drawing.Point(70, 228);
            this.btnUserGuncelle.Name = "btnUserGuncelle";
            this.btnUserGuncelle.Size = new System.Drawing.Size(60, 25);
            this.btnUserGuncelle.TabIndex = 24;
            this.btnUserGuncelle.Text = "Guncelle";
            this.btnUserGuncelle.UseVisualStyleBackColor = true;
            this.btnUserGuncelle.Click += new System.EventHandler(this.btnUserGuncelle_Click);
            // 
            // chUserAktifMi
            // 
            this.chUserAktifMi.AutoSize = true;
            this.chUserAktifMi.Location = new System.Drawing.Point(98, 205);
            this.chUserAktifMi.Name = "chUserAktifMi";
            this.chUserAktifMi.Size = new System.Drawing.Size(67, 17);
            this.chUserAktifMi.TabIndex = 19;
            this.chUserAktifMi.Text = "Aktif Mi?";
            this.chUserAktifMi.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(70, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 20);
            this.txtID.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyadı :";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(70, 133);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(132, 20);
            this.txtSoyadi.TabIndex = 5;
            // 
            // chSilinenUserleriGoster
            // 
            this.chSilinenUserleriGoster.AutoSize = true;
            this.chSilinenUserleriGoster.BackColor = System.Drawing.Color.Transparent;
            this.chSilinenUserleriGoster.Location = new System.Drawing.Point(174, 12);
            this.chSilinenUserleriGoster.Name = "chSilinenUserleriGoster";
            this.chSilinenUserleriGoster.Size = new System.Drawing.Size(104, 17);
            this.chSilinenUserleriGoster.TabIndex = 23;
            this.chSilinenUserleriGoster.Text = "Silinenleri Göster";
            this.chSilinenUserleriGoster.UseVisualStyleBackColor = false;
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
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminUserControlUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 462);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpUserBilgileri);
            this.Controls.Add(this.chSilinenUserleriGoster);
            this.Controls.Add(this.lstUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUserControlUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminUserControlUI";
            this.Load += new System.EventHandler(this.AdminUserControlUI_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpUserBilgileri.ResumeLayout(false);
            this.grpUserBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.GroupBox grpUserBilgileri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chUserAktifMi;
        private System.Windows.Forms.CheckBox chSilinenUserleriGoster;
        private System.Windows.Forms.Button btnUserGuncelle;
        private System.Windows.Forms.Button btnUserAra;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button button1;
    }
}