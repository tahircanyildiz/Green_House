namespace GreenHouse.UI.UserUI
{
    partial class FrmSearchHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchHistory));
            this.label1 = new System.Windows.Forms.Label();
            this.lstSearchHistory = new System.Windows.Forms.ListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnDeleteAll = new System.Windows.Forms.Button();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.BtnSideMenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama  Geçmişi";
            // 
            // lstSearchHistory
            // 
            this.lstSearchHistory.FormattingEnabled = true;
            this.lstSearchHistory.ItemHeight = 16;
            this.lstSearchHistory.Location = new System.Drawing.Point(76, 94);
            this.lstSearchHistory.Name = "lstSearchHistory";
            this.lstSearchHistory.Size = new System.Drawing.Size(240, 244);
            this.lstSearchHistory.TabIndex = 1;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDelete.Location = new System.Drawing.Point(76, 363);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 49);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnDeleteAll
            // 
            this.BtnDeleteAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteAll.BackgroundImage")));
            this.BtnDeleteAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDeleteAll.Location = new System.Drawing.Point(241, 363);
            this.BtnDeleteAll.Name = "BtnDeleteAll";
            this.BtnDeleteAll.Size = new System.Drawing.Size(75, 49);
            this.BtnDeleteAll.TabIndex = 3;
            this.BtnDeleteAll.UseVisualStyleBackColor = true;
            this.BtnDeleteAll.Click += new System.EventHandler(this.BtnDeleteAll_Click);
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMainMenu.BackgroundImage")));
            this.BtnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMainMenu.Location = new System.Drawing.Point(12, 408);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(49, 48);
            this.BtnMainMenu.TabIndex = 13;
            this.BtnMainMenu.UseVisualStyleBackColor = false;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.BackColor = System.Drawing.SystemColors.Control;
            this.BtnProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnProfile.BackgroundImage")));
            this.BtnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnProfile.Location = new System.Drawing.Point(338, 12);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(49, 48);
            this.BtnProfile.TabIndex = 12;
            this.BtnProfile.UseVisualStyleBackColor = false;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // BtnSideMenu
            // 
            this.BtnSideMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSideMenu.BackgroundImage")));
            this.BtnSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSideMenu.Location = new System.Drawing.Point(12, 12);
            this.BtnSideMenu.Name = "BtnSideMenu";
            this.BtnSideMenu.Size = new System.Drawing.Size(49, 48);
            this.BtnSideMenu.TabIndex = 11;
            this.BtnSideMenu.UseVisualStyleBackColor = false;
            this.BtnSideMenu.Click += new System.EventHandler(this.BtnSideMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(338, 408);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // FrmSearchHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GreenHouse.UI.Properties.Resources.Green_Illustrative_Organic_Plant_Zoom_Virtual_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(399, 468);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.BtnProfile);
            this.Controls.Add(this.BtnSideMenu);
            this.Controls.Add(this.BtnDeleteAll);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.lstSearchHistory);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSearchHistory";
            this.Load += new System.EventHandler(this.FrmSearchHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSearchHistory;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnDeleteAll;
        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button BtnSideMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}