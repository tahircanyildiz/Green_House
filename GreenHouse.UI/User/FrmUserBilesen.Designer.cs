namespace GreenHouse.UI.User
{
    partial class FrmUserBilesen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserBilesen));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBilesenAciklama = new System.Windows.Forms.RichTextBox();
            this.lblBilesenSayisi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBilesen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBilesen = new System.Windows.Forms.RichTextBox();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnGuncelle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnSil = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnBilesenAciklama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, -4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 372);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(265, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 15);
            this.label10.TabIndex = 56;
            this.label10.Text = "Bilesen Acikalama :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBilesenAciklama
            // 
            this.txtBilesenAciklama.Location = new System.Drawing.Point(391, 106);
            this.txtBilesenAciklama.Name = "txtBilesenAciklama";
            this.txtBilesenAciklama.Size = new System.Drawing.Size(201, 81);
            this.txtBilesenAciklama.TabIndex = 55;
            this.txtBilesenAciklama.Text = "";
            // 
            // lblBilesenSayisi
            // 
            this.lblBilesenSayisi.AutoSize = true;
            this.lblBilesenSayisi.Location = new System.Drawing.Point(271, 76);
            this.lblBilesenSayisi.Name = "lblBilesenSayisi";
            this.lblBilesenSayisi.Size = new System.Drawing.Size(14, 16);
            this.lblBilesenSayisi.TabIndex = 54;
            this.lblBilesenSayisi.Text = "0";
            this.lblBilesenSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "Mevcut Bilesen :";
            // 
            // cmbBilesen
            // 
            this.cmbBilesen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBilesen.FormattingEnabled = true;
            this.cmbBilesen.Location = new System.Drawing.Point(391, 60);
            this.cmbBilesen.Name = "cmbBilesen";
            this.cmbBilesen.Size = new System.Drawing.Size(199, 24);
            this.cmbBilesen.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Bilesen : ";
            // 
            // txtBilesen
            // 
            this.txtBilesen.Location = new System.Drawing.Point(391, 21);
            this.txtBilesen.Name = "txtBilesen";
            this.txtBilesen.Size = new System.Drawing.Size(199, 30);
            this.txtBilesen.TabIndex = 49;
            this.txtBilesen.Text = "";
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.FillColor = System.Drawing.Color.Transparent;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.Transparent;
            this.BtnClose.Location = new System.Drawing.Point(598, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(32, 28);
            this.BtnClose.TabIndex = 60;
            this.BtnClose.Text = "guna2Button1";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.BackgroundImage")));
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnGuncelle.FillColor = System.Drawing.Color.Transparent;
            this.BtnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuncelle.ForeColor = System.Drawing.Color.White;
            this.BtnGuncelle.IndicateFocus = true;
            this.BtnGuncelle.Location = new System.Drawing.Point(500, 246);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnGuncelle.Size = new System.Drawing.Size(78, 69);
            this.BtnGuncelle.TabIndex = 59;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSil.BackgroundImage")));
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSil.FillColor = System.Drawing.Color.Transparent;
            this.BtnSil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSil.ForeColor = System.Drawing.Color.White;
            this.BtnSil.Location = new System.Drawing.Point(307, 246);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnSil.Size = new System.Drawing.Size(78, 69);
            this.BtnSil.TabIndex = 58;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnBilesenAciklama
            // 
            this.BtnBilesenAciklama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBilesenAciklama.BackgroundImage")));
            this.BtnBilesenAciklama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBilesenAciklama.Location = new System.Drawing.Point(596, 133);
            this.BtnBilesenAciklama.Name = "BtnBilesenAciklama";
            this.BtnBilesenAciklama.Size = new System.Drawing.Size(30, 30);
            this.BtnBilesenAciklama.TabIndex = 57;
            this.BtnBilesenAciklama.UseVisualStyleBackColor = true;
            // 
            // FrmUserBilesen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 365);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnBilesenAciklama);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBilesenAciklama);
            this.Controls.Add(this.lblBilesenSayisi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBilesen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBilesen);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserBilesen";
            this.Text = "FrmUserContent";
            this.Load += new System.EventHandler(this.FrmUserBilesen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2CircleButton BtnGuncelle;
        private Guna.UI2.WinForms.Guna2CircleButton BtnSil;
        private System.Windows.Forms.Button BtnBilesenAciklama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtBilesenAciklama;
        private System.Windows.Forms.Label lblBilesenSayisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBilesen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtBilesen;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
    }
}