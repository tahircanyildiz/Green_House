
namespace GreenHouse.UI.User
{
    partial class FrmFavoriteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFavoriteList));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtListeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddFavoriteProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Favori Listesi Ekleme Ekranı";
            // 
            // TxtListeAdi
            // 
            this.TxtListeAdi.Location = new System.Drawing.Point(156, 143);
            this.TxtListeAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtListeAdi.Name = "TxtListeAdi";
            this.TxtListeAdi.Size = new System.Drawing.Size(211, 22);
            this.TxtListeAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liste Adı:";
            // 
            // BtnAddFavoriteProduct
            // 
            this.BtnAddFavoriteProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddFavoriteProduct.BackgroundImage")));
            this.BtnAddFavoriteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddFavoriteProduct.Location = new System.Drawing.Point(225, 194);
            this.BtnAddFavoriteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddFavoriteProduct.Name = "BtnAddFavoriteProduct";
            this.BtnAddFavoriteProduct.Size = new System.Drawing.Size(72, 48);
            this.BtnAddFavoriteProduct.TabIndex = 18;
            this.BtnAddFavoriteProduct.UseVisualStyleBackColor = true;
            this.BtnAddFavoriteProduct.Click += new System.EventHandler(this.BtnAddFavoriteProduct_Click);
            // 
            // FrmFavoriteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(487, 374);
            this.Controls.Add(this.BtnAddFavoriteProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtListeAdi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFavoriteList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmFavoriteList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtListeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddFavoriteProduct;
    }
}