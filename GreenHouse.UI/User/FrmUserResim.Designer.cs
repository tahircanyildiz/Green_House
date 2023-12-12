namespace GreenHouse.UI.User
{
    partial class FrmUserResim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserResim));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnGuncelle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnSil = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblResimSayisi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnFrontProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtResimYol = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, -4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 372);
            this.listBox1.TabIndex = 60;
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
            this.BtnGuncelle.TabIndex = 62;
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
            this.BtnSil.TabIndex = 61;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
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
            this.BtnClose.Location = new System.Drawing.Point(553, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(32, 28);
            this.BtnClose.TabIndex = 63;
            this.BtnClose.Text = "guna2Button1";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblResimSayisi
            // 
            this.lblResimSayisi.AutoSize = true;
            this.lblResimSayisi.Location = new System.Drawing.Point(459, 184);
            this.lblResimSayisi.Name = "lblResimSayisi";
            this.lblResimSayisi.Size = new System.Drawing.Size(14, 16);
            this.lblResimSayisi.TabIndex = 66;
            this.lblResimSayisi.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 65;
            this.label8.Text = "Resim Sayisi :";
            // 
            // BtnFrontProduct
            // 
            this.BtnFrontProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFrontProduct.BackgroundImage")));
            this.BtnFrontProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFrontProduct.Location = new System.Drawing.Point(526, 98);
            this.BtnFrontProduct.Name = "BtnFrontProduct";
            this.BtnFrontProduct.Size = new System.Drawing.Size(40, 38);
            this.BtnFrontProduct.TabIndex = 64;
            this.BtnFrontProduct.UseVisualStyleBackColor = true;
            this.BtnFrontProduct.Click += new System.EventHandler(this.BtnFrontProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Resim Yolu :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtResimYol
            // 
            this.txtResimYol.Enabled = false;
            this.txtResimYol.Location = new System.Drawing.Point(307, 86);
            this.txtResimYol.Name = "txtResimYol";
            this.txtResimYol.Size = new System.Drawing.Size(207, 65);
            this.txtResimYol.TabIndex = 68;
            this.txtResimYol.Text = "";
            // 
            // FrmUserResim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 367);
            this.Controls.Add(this.txtResimYol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResimSayisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnFrontProduct);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserResim";
            this.Text = "FrmUserResim";
            this.Load += new System.EventHandler(this.FrmUserResim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton BtnGuncelle;
        private Guna.UI2.WinForms.Guna2CircleButton BtnSil;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResimSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnFrontProduct;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txtResimYol;
    }
}