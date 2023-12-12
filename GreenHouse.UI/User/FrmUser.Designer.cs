namespace GreenHouse.UI.UserUI
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.BtnSideMenu = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSinceUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUserAddedProduct = new System.Windows.Forms.Label();
            this.BtnPremiumUser = new System.Windows.Forms.Button();
            this.BtnChangeEmail = new System.Windows.Forms.Button();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.BtnLinkWithSocialMedia = new System.Windows.Forms.Button();
            this.BtnUpdateProfile = new System.Windows.Forms.Button();
            this.BtnFavorites = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClearSearchHistory = new System.Windows.Forms.Button();
            this.BtnBlackList = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMainMenu.BackgroundImage")));
            this.BtnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMainMenu.Enabled = false;
            this.BtnMainMenu.Location = new System.Drawing.Point(12, 490);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(49, 48);
            this.BtnMainMenu.TabIndex = 13;
            this.BtnMainMenu.UseVisualStyleBackColor = false;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // BtnSideMenu
            // 
            this.BtnSideMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSideMenu.BackgroundImage")));
            this.BtnSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSideMenu.Enabled = false;
            this.BtnSideMenu.Location = new System.Drawing.Point(12, 12);
            this.BtnSideMenu.Name = "BtnSideMenu";
            this.BtnSideMenu.Size = new System.Drawing.Size(49, 48);
            this.BtnSideMenu.TabIndex = 11;
            this.BtnSideMenu.UseVisualStyleBackColor = false;
            this.BtnSideMenu.Click += new System.EventHandler(this.BtnSideMenu_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(189, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(45, 16);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Üyelik Tarihi :";
            // 
            // lblSinceUser
            // 
            this.lblSinceUser.AutoSize = true;
            this.lblSinceUser.Location = new System.Drawing.Point(230, 74);
            this.lblSinceUser.Name = "lblSinceUser";
            this.lblSinceUser.Size = new System.Drawing.Size(80, 16);
            this.lblSinceUser.TabIndex = 16;
            this.lblSinceUser.Text = "1 Ocak 2020";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Eklediği Ürün Sayısı :";
            // 
            // lblUserAddedProduct
            // 
            this.lblUserAddedProduct.AutoSize = true;
            this.lblUserAddedProduct.Location = new System.Drawing.Point(263, 114);
            this.lblUserAddedProduct.Name = "lblUserAddedProduct";
            this.lblUserAddedProduct.Size = new System.Drawing.Size(14, 16);
            this.lblUserAddedProduct.TabIndex = 18;
            this.lblUserAddedProduct.Text = "0";
            // 
            // BtnPremiumUser
            // 
            this.BtnPremiumUser.Location = new System.Drawing.Point(96, 156);
            this.BtnPremiumUser.Name = "BtnPremiumUser";
            this.BtnPremiumUser.Size = new System.Drawing.Size(227, 30);
            this.BtnPremiumUser.TabIndex = 19;
            this.BtnPremiumUser.Text = "Premium Üye Ol";
            this.BtnPremiumUser.UseVisualStyleBackColor = true;
            this.BtnPremiumUser.Click += new System.EventHandler(this.BtnPremiumUser_Click);
            // 
            // BtnChangeEmail
            // 
            this.BtnChangeEmail.Location = new System.Drawing.Point(96, 192);
            this.BtnChangeEmail.Name = "BtnChangeEmail";
            this.BtnChangeEmail.Size = new System.Drawing.Size(227, 30);
            this.BtnChangeEmail.TabIndex = 20;
            this.BtnChangeEmail.Text = "E-Posta adresini değiştir";
            this.BtnChangeEmail.UseVisualStyleBackColor = true;
            this.BtnChangeEmail.Click += new System.EventHandler(this.BtnChangeEmail_Click);
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.Location = new System.Drawing.Point(96, 228);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(227, 30);
            this.BtnChangePassword.TabIndex = 21;
            this.BtnChangePassword.Text = "Şifre değiştir";
            this.BtnChangePassword.UseVisualStyleBackColor = true;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // BtnLinkWithSocialMedia
            // 
            this.BtnLinkWithSocialMedia.Location = new System.Drawing.Point(96, 264);
            this.BtnLinkWithSocialMedia.Name = "BtnLinkWithSocialMedia";
            this.BtnLinkWithSocialMedia.Size = new System.Drawing.Size(227, 30);
            this.BtnLinkWithSocialMedia.TabIndex = 22;
            this.BtnLinkWithSocialMedia.Text = "Sosyal medya hesabı ile birleştir";
            this.BtnLinkWithSocialMedia.UseVisualStyleBackColor = true;
            this.BtnLinkWithSocialMedia.Click += new System.EventHandler(this.BtnLinkWithSocialMedia_Click);
            // 
            // BtnUpdateProfile
            // 
            this.BtnUpdateProfile.Location = new System.Drawing.Point(96, 300);
            this.BtnUpdateProfile.Name = "BtnUpdateProfile";
            this.BtnUpdateProfile.Size = new System.Drawing.Size(227, 30);
            this.BtnUpdateProfile.TabIndex = 23;
            this.BtnUpdateProfile.Text = "Profil bilgilerini güncelle";
            this.BtnUpdateProfile.UseVisualStyleBackColor = true;
            this.BtnUpdateProfile.Click += new System.EventHandler(this.BtnUpdateProfile_Click);
            // 
            // BtnFavorites
            // 
            this.BtnFavorites.Location = new System.Drawing.Point(96, 336);
            this.BtnFavorites.Name = "BtnFavorites";
            this.BtnFavorites.Size = new System.Drawing.Size(227, 30);
            this.BtnFavorites.TabIndex = 24;
            this.BtnFavorites.Text = "Favoriler";
            this.BtnFavorites.UseVisualStyleBackColor = true;
            this.BtnFavorites.Click += new System.EventHandler(this.BtnFavorites_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(96, 444);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(227, 30);
            this.BtnExit.TabIndex = 27;
            this.BtnExit.Text = "Çıkış yap";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClearSearchHistory
            // 
            this.BtnClearSearchHistory.Location = new System.Drawing.Point(96, 408);
            this.BtnClearSearchHistory.Name = "BtnClearSearchHistory";
            this.BtnClearSearchHistory.Size = new System.Drawing.Size(227, 30);
            this.BtnClearSearchHistory.TabIndex = 26;
            this.BtnClearSearchHistory.Text = "Arama geçmişini temizle";
            this.BtnClearSearchHistory.UseVisualStyleBackColor = true;
            this.BtnClearSearchHistory.Click += new System.EventHandler(this.BtnClearSearchHistory_Click);
            // 
            // BtnBlackList
            // 
            this.BtnBlackList.Location = new System.Drawing.Point(96, 372);
            this.BtnBlackList.Name = "BtnBlackList";
            this.BtnBlackList.Size = new System.Drawing.Size(227, 30);
            this.BtnBlackList.TabIndex = 25;
            this.BtnBlackList.Text = "Kara liste";
            this.BtnBlackList.UseVisualStyleBackColor = true;
            this.BtnBlackList.Click += new System.EventHandler(this.BtnBlackList_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(345, 483);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(66, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(345, 303);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 174);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 300);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 174);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 156);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(66, 138);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 32;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(345, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::GreenHouse.UI.Properties.Resources.Green_Illustrative_Organic_Plant_Zoom_Virtual_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 550);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClearSearchHistory);
            this.Controls.Add(this.BtnBlackList);
            this.Controls.Add(this.BtnFavorites);
            this.Controls.Add(this.BtnUpdateProfile);
            this.Controls.Add(this.BtnLinkWithSocialMedia);
            this.Controls.Add(this.BtnChangePassword);
            this.Controls.Add(this.BtnChangeEmail);
            this.Controls.Add(this.BtnPremiumUser);
            this.Controls.Add(this.lblUserAddedProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSinceUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.BtnSideMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.Button BtnSideMenu;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSinceUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUserAddedProduct;
        private System.Windows.Forms.Button BtnPremiumUser;
        private System.Windows.Forms.Button BtnChangeEmail;
        private System.Windows.Forms.Button BtnChangePassword;
        private System.Windows.Forms.Button BtnLinkWithSocialMedia;
        private System.Windows.Forms.Button BtnUpdateProfile;
        private System.Windows.Forms.Button BtnFavorites;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClearSearchHistory;
        private System.Windows.Forms.Button BtnBlackList;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}