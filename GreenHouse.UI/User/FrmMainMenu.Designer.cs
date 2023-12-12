namespace GreenHouse.UI.UserUI
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.BtnBarcodeRead = new System.Windows.Forms.Button();
            this.BtnSideMenu = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.BtnSearchHistory = new System.Windows.Forms.Button();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBarcodeRead
            // 
            this.BtnBarcodeRead.Location = new System.Drawing.Point(71, 199);
            this.BtnBarcodeRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBarcodeRead.Name = "BtnBarcodeRead";
            this.BtnBarcodeRead.Size = new System.Drawing.Size(229, 50);
            this.BtnBarcodeRead.TabIndex = 0;
            this.BtnBarcodeRead.Text = "Barkod Okuma";
            this.BtnBarcodeRead.UseVisualStyleBackColor = true;
            this.BtnBarcodeRead.Click += new System.EventHandler(this.BtnBarcodeRead_Click);
            // 
            // BtnSideMenu
            // 
            this.BtnSideMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSideMenu.BackgroundImage")));
            this.BtnSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSideMenu.Location = new System.Drawing.Point(12, 25);
            this.BtnSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSideMenu.Name = "BtnSideMenu";
            this.BtnSideMenu.Size = new System.Drawing.Size(49, 48);
            this.BtnSideMenu.TabIndex = 2;
            this.BtnSideMenu.UseVisualStyleBackColor = false;
            this.BtnSideMenu.Click += new System.EventHandler(this.BtnSideMenu_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.BackColor = System.Drawing.SystemColors.Control;
            this.BtnProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnProfile.BackgroundImage")));
            this.BtnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnProfile.Location = new System.Drawing.Point(347, 25);
            this.BtnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(49, 48);
            this.BtnProfile.TabIndex = 3;
            this.BtnProfile.UseVisualStyleBackColor = false;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(71, 324);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(229, 50);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Arama";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Location = new System.Drawing.Point(71, 469);
            this.BtnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(229, 50);
            this.BtnAddProduct.TabIndex = 5;
            this.BtnAddProduct.Text = "Ürün ekleme/düzeltme";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnSearchHistory
            // 
            this.BtnSearchHistory.Location = new System.Drawing.Point(71, 634);
            this.BtnSearchHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearchHistory.Name = "BtnSearchHistory";
            this.BtnSearchHistory.Size = new System.Drawing.Size(229, 50);
            this.BtnSearchHistory.TabIndex = 6;
            this.BtnSearchHistory.Text = "Arama geçmişi/favoriler";
            this.BtnSearchHistory.UseVisualStyleBackColor = true;
            this.BtnSearchHistory.Click += new System.EventHandler(this.BtnSearchHistory_Click);
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMainMenu.BackgroundImage")));
            this.BtnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMainMenu.Location = new System.Drawing.Point(12, 774);
            this.BtnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(49, 48);
            this.BtnMainMenu.TabIndex = 7;
            this.BtnMainMenu.UseVisualStyleBackColor = false;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(305, 634);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(305, 469);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(305, 324);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 199);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(163, 767);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(329, 767);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(67, 55);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 45;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 49);
            this.label1.TabIndex = 47;
            this.label1.Text = "ANA MENÜ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::GreenHouse.UI.Properties.Resources.Green_Illustrative_Organic_Plant_Zoom_Virtual_Background;
            this.ClientSize = new System.Drawing.Size(408, 833);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.BtnSearchHistory);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnProfile);
            this.Controls.Add(this.BtnSideMenu);
            this.Controls.Add(this.BtnBarcodeRead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBarcodeRead;
        private System.Windows.Forms.Button BtnSideMenu;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Button BtnSearchHistory;
        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
    }
}