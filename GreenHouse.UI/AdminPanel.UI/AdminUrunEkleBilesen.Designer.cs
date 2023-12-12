
namespace GreenHouse.UI.AdminPanel.UI.UrunEklemeFormlari
{
    partial class AdminUrunEkleBilesen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUrunEkleBilesen));
            this.lstBilesenler = new System.Windows.Forms.ListBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbRiskler = new System.Windows.Forms.ComboBox();
            this.txtBilesenAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBilesenler
            // 
            this.lstBilesenler.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBilesenler.FormattingEnabled = true;
            this.lstBilesenler.ItemHeight = 16;
            this.lstBilesenler.Location = new System.Drawing.Point(0, 0);
            this.lstBilesenler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBilesenler.Name = "lstBilesenler";
            this.lstBilesenler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBilesenler.Size = new System.Drawing.Size(213, 502);
            this.lstBilesenler.TabIndex = 33;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(253, 18);
            this.btnSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(80, 33);
            this.btnSec.TabIndex = 35;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::GreenHouse.UI.Properties.Resources.Ekran_görüntüsü_2023_11_10_011157;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(585, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 33);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(475, 271);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 31);
            this.btnEkle.TabIndex = 50;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbRiskler
            // 
            this.cmbRiskler.FormattingEnabled = true;
            this.cmbRiskler.Location = new System.Drawing.Point(376, 225);
            this.cmbRiskler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRiskler.Name = "cmbRiskler";
            this.cmbRiskler.Size = new System.Drawing.Size(177, 24);
            this.cmbRiskler.TabIndex = 49;
            // 
            // txtBilesenAdi
            // 
            this.txtBilesenAdi.Location = new System.Drawing.Point(376, 143);
            this.txtBilesenAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBilesenAdi.Name = "txtBilesenAdi";
            this.txtBilesenAdi.Size = new System.Drawing.Size(177, 22);
            this.txtBilesenAdi.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(271, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Bileşen Adı :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(376, 183);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(177, 22);
            this.txtAciklama.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(287, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Açıklama :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(317, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Riski :";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(428, 108);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(69, 28);
            this.btnTemizle.TabIndex = 54;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(505, 108);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(49, 28);
            this.btnAra.TabIndex = 53;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // AdminUrunEkleBilesen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(692, 502);
            this.ControlBox = false;
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbRiskler);
            this.Controls.Add(this.txtBilesenAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstBilesenler);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminUrunEkleBilesen";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminUrunEkleBilesen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBilesenler;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbRiskler;
        private System.Windows.Forms.TextBox txtBilesenAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
    }
}