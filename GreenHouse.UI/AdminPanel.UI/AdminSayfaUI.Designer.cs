
namespace GreenHouse.UI.AdminPanel.UI
{
    partial class AdminSayfaUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSayfaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSayfalar = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sayfaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSayfaAra = new System.Windows.Forms.Button();
            this.btnSayfaGuncelle = new System.Windows.Forms.Button();
            this.btnSayfaEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1.SuspendLayout();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "O";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSayfaAdi
            // 
            this.txtSayfaAdi.Location = new System.Drawing.Point(96, 88);
            this.txtSayfaAdi.Name = "txtSayfaAdi";
            this.txtSayfaAdi.Size = new System.Drawing.Size(162, 20);
            this.txtSayfaAdi.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Adı :";
            // 
            // lstSayfalar
            // 
            this.lstSayfalar.ContextMenuStrip = this.contextMenuStrip1;
            this.lstSayfalar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstSayfalar.FormattingEnabled = true;
            this.lstSayfalar.Location = new System.Drawing.Point(0, 0);
            this.lstSayfalar.Name = "lstSayfalar";
            this.lstSayfalar.Size = new System.Drawing.Size(156, 462);
            this.lstSayfalar.TabIndex = 0;
            this.lstSayfalar.SelectedIndexChanged += new System.EventHandler(this.lstSayfalar_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sayfaSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // sayfaSilToolStripMenuItem
            // 
            this.sayfaSilToolStripMenuItem.Name = "sayfaSilToolStripMenuItem";
            this.sayfaSilToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sayfaSilToolStripMenuItem.Text = "SayfaSil";
            this.sayfaSilToolStripMenuItem.Click += new System.EventHandler(this.sayfaSilToolStripMenuItem_Click);
            // 
            // btnSayfaAra
            // 
            this.btnSayfaAra.Location = new System.Drawing.Point(192, 59);
            this.btnSayfaAra.Name = "btnSayfaAra";
            this.btnSayfaAra.Size = new System.Drawing.Size(37, 23);
            this.btnSayfaAra.TabIndex = 10;
            this.btnSayfaAra.Text = "Ara";
            this.btnSayfaAra.UseVisualStyleBackColor = true;
            this.btnSayfaAra.Click += new System.EventHandler(this.btnSayfaAra_Click);
            // 
            // btnSayfaGuncelle
            // 
            this.btnSayfaGuncelle.Location = new System.Drawing.Point(183, 114);
            this.btnSayfaGuncelle.Name = "btnSayfaGuncelle";
            this.btnSayfaGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnSayfaGuncelle.TabIndex = 12;
            this.btnSayfaGuncelle.Text = "Güncelle";
            this.btnSayfaGuncelle.UseVisualStyleBackColor = true;
            this.btnSayfaGuncelle.Click += new System.EventHandler(this.btnSayfaGuncelle_Click);
            // 
            // btnSayfaEkle
            // 
            this.btnSayfaEkle.Location = new System.Drawing.Point(96, 114);
            this.btnSayfaEkle.Name = "btnSayfaEkle";
            this.btnSayfaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSayfaEkle.TabIndex = 11;
            this.btnSayfaEkle.Text = "Ekle";
            this.btnSayfaEkle.UseVisualStyleBackColor = true;
            this.btnSayfaEkle.Click += new System.EventHandler(this.btnSayfaEkle_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::GreenHouse.UI.Properties.Resources.Ekran_görüntüsü_2023_11_10_011157;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(630, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 27);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.BackColor = System.Drawing.Color.Transparent;
            this.grpMenu.Controls.Add(this.button1);
            this.grpMenu.Controls.Add(this.txtSayfaAdi);
            this.grpMenu.Controls.Add(this.label1);
            this.grpMenu.Controls.Add(this.btnSayfaAra);
            this.grpMenu.Controls.Add(this.btnSayfaGuncelle);
            this.grpMenu.Controls.Add(this.btnSayfaEkle);
            this.grpMenu.Location = new System.Drawing.Point(247, 140);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(332, 192);
            this.grpMenu.TabIndex = 10;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Sayfa";
            // 
            // AdminSayfaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(700, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lstSayfalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSayfaUI";
            this.Text = "AdminSayfaUI";
            this.Load += new System.EventHandler(this.AdminSayfaUI_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSayfaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSayfalar;
        private System.Windows.Forms.Button btnSayfaAra;
        private System.Windows.Forms.Button btnSayfaGuncelle;
        private System.Windows.Forms.Button btnSayfaEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sayfaSilToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpMenu;
    }
}