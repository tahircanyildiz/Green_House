
namespace GreenHouse.UI.AdminPanel.UI
{
    partial class AdminYetkiUI
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
            this.grpYetki = new System.Windows.Forms.GroupBox();
            this.btnFiltreTemizle = new System.Windows.Forms.Button();
            this.txtYetkiAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYetkiAra = new System.Windows.Forms.Button();
            this.btnYetkiGuncelle = new System.Windows.Forms.Button();
            this.btnYetkiEkle = new System.Windows.Forms.Button();
            this.lstYetkiler = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.grpYetki.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpYetki
            // 
            this.grpYetki.BackColor = System.Drawing.Color.Transparent;
            this.grpYetki.Controls.Add(this.btnFiltreTemizle);
            this.grpYetki.Controls.Add(this.txtYetkiAdi);
            this.grpYetki.Controls.Add(this.label1);
            this.grpYetki.Controls.Add(this.btnYetkiAra);
            this.grpYetki.Controls.Add(this.btnYetkiGuncelle);
            this.grpYetki.Controls.Add(this.btnYetkiEkle);
            this.grpYetki.Location = new System.Drawing.Point(280, 151);
            this.grpYetki.Name = "grpYetki";
            this.grpYetki.Size = new System.Drawing.Size(292, 112);
            this.grpYetki.TabIndex = 2;
            this.grpYetki.TabStop = false;
            this.grpYetki.Text = "Yetki";
            // 
            // btnFiltreTemizle
            // 
            this.btnFiltreTemizle.Location = new System.Drawing.Point(244, 22);
            this.btnFiltreTemizle.Name = "btnFiltreTemizle";
            this.btnFiltreTemizle.Size = new System.Drawing.Size(27, 23);
            this.btnFiltreTemizle.TabIndex = 21;
            this.btnFiltreTemizle.Text = "O";
            this.btnFiltreTemizle.UseVisualStyleBackColor = true;
            this.btnFiltreTemizle.Click += new System.EventHandler(this.btnFiltreTemizle_Click);
            // 
            // txtYetkiAdi
            // 
            this.txtYetkiAdi.Location = new System.Drawing.Point(55, 24);
            this.txtYetkiAdi.Name = "txtYetkiAdi";
            this.txtYetkiAdi.Size = new System.Drawing.Size(140, 20);
            this.txtYetkiAdi.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Adı :";
            // 
            // btnYetkiAra
            // 
            this.btnYetkiAra.Location = new System.Drawing.Point(201, 22);
            this.btnYetkiAra.Name = "btnYetkiAra";
            this.btnYetkiAra.Size = new System.Drawing.Size(37, 23);
            this.btnYetkiAra.TabIndex = 10;
            this.btnYetkiAra.Text = "Ara";
            this.btnYetkiAra.UseVisualStyleBackColor = true;
            this.btnYetkiAra.Click += new System.EventHandler(this.btnYetkiAra_Click);
            // 
            // btnYetkiGuncelle
            // 
            this.btnYetkiGuncelle.Location = new System.Drawing.Point(136, 68);
            this.btnYetkiGuncelle.Name = "btnYetkiGuncelle";
            this.btnYetkiGuncelle.Size = new System.Drawing.Size(59, 23);
            this.btnYetkiGuncelle.TabIndex = 12;
            this.btnYetkiGuncelle.Text = "Guncelle";
            this.btnYetkiGuncelle.UseVisualStyleBackColor = true;
            this.btnYetkiGuncelle.Click += new System.EventHandler(this.btnYetkiGuncelle_Click);
            // 
            // btnYetkiEkle
            // 
            this.btnYetkiEkle.Location = new System.Drawing.Point(55, 68);
            this.btnYetkiEkle.Name = "btnYetkiEkle";
            this.btnYetkiEkle.Size = new System.Drawing.Size(63, 23);
            this.btnYetkiEkle.TabIndex = 11;
            this.btnYetkiEkle.Text = "Ekle";
            this.btnYetkiEkle.UseVisualStyleBackColor = true;
            this.btnYetkiEkle.Click += new System.EventHandler(this.btnYetkiEkle_Click);
            // 
            // lstYetkiler
            // 
            this.lstYetkiler.ContextMenuStrip = this.contextMenuStrip1;
            this.lstYetkiler.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstYetkiler.FormattingEnabled = true;
            this.lstYetkiler.Location = new System.Drawing.Point(0, 0);
            this.lstYetkiler.Name = "lstYetkiler";
            this.lstYetkiler.Size = new System.Drawing.Size(182, 462);
            this.lstYetkiler.TabIndex = 0;
            this.lstYetkiler.SelectedIndexChanged += new System.EventHandler(this.lstYetkiler_SelectedIndexChanged);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GreenHouse.UI.Properties.Resources.Ekran_görüntüsü_2023_11_10_011157;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(630, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 27);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminYetkiUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 462);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpYetki);
            this.Controls.Add(this.lstYetkiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminYetkiUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "AdminYetkiUI";
            this.Load += new System.EventHandler(this.AdminYetkiUI_Load);
            this.grpYetki.ResumeLayout(false);
            this.grpYetki.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpYetki;
        private System.Windows.Forms.TextBox txtYetkiAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstYetkiler;
        private System.Windows.Forms.Button btnYetkiAra;
        private System.Windows.Forms.Button btnYetkiGuncelle;
        private System.Windows.Forms.Button btnYetkiEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnFiltreTemizle;
        private System.Windows.Forms.Button button1;
    }
}