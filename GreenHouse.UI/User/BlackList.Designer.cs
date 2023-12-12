namespace GreenHouse.UI.User
{
    partial class BlackList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnSilUrun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBlackListProduct = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.BtnSilIcerik = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBlackListIngredient = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.BtnSilUrun);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstBlackListProduct);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(515, 594);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kara Liste(Ürün)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 481);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "! Sürükle, bırakla ekleme yapabilirsin";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(276, 25);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 436);
            this.listBox1.TabIndex = 9;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // BtnSilUrun
            // 
            this.BtnSilUrun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSilUrun.BackgroundImage")));
            this.BtnSilUrun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSilUrun.Location = new System.Drawing.Point(213, 514);
            this.BtnSilUrun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSilUrun.Name = "BtnSilUrun";
            this.BtnSilUrun.Size = new System.Drawing.Size(65, 58);
            this.BtnSilUrun.TabIndex = 4;
            this.BtnSilUrun.UseVisualStyleBackColor = true;
            this.BtnSilUrun.Click += new System.EventHandler(this.BtnSilUrun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // lstBlackListProduct
            // 
            this.lstBlackListProduct.AllowDrop = true;
            this.lstBlackListProduct.FormattingEnabled = true;
            this.lstBlackListProduct.ItemHeight = 16;
            this.lstBlackListProduct.Location = new System.Drawing.Point(8, 23);
            this.lstBlackListProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBlackListProduct.Name = "lstBlackListProduct";
            this.lstBlackListProduct.Size = new System.Drawing.Size(193, 436);
            this.lstBlackListProduct.TabIndex = 0;
            this.lstBlackListProduct.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstBlackListProduct_DragDrop);
            this.lstBlackListProduct.DragOver += new System.Windows.Forms.DragEventHandler(this.lstBlackListProduct_DragOver);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.BtnSilIcerik);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lstBlackListIngredient);
            this.groupBox2.Location = new System.Drawing.Point(539, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(531, 594);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kara Liste(İçerik)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(129, 481);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "! Sürükle, bırakla ekleme yapabilirsin";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(287, 25);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(195, 436);
            this.listBox2.TabIndex = 14;
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            // 
            // BtnSilIcerik
            // 
            this.BtnSilIcerik.BackColor = System.Drawing.Color.Transparent;
            this.BtnSilIcerik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSilIcerik.BackgroundImage")));
            this.BtnSilIcerik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSilIcerik.Location = new System.Drawing.Point(220, 514);
            this.BtnSilIcerik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSilIcerik.Name = "BtnSilIcerik";
            this.BtnSilIcerik.Size = new System.Drawing.Size(65, 58);
            this.BtnSilIcerik.TabIndex = 9;
            this.BtnSilIcerik.UseVisualStyleBackColor = false;
            this.BtnSilIcerik.Click += new System.EventHandler(this.BtnSilIcerik_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçerik Adı:";
            // 
            // lstBlackListIngredient
            // 
            this.lstBlackListIngredient.AllowDrop = true;
            this.lstBlackListIngredient.FormattingEnabled = true;
            this.lstBlackListIngredient.ItemHeight = 16;
            this.lstBlackListIngredient.Location = new System.Drawing.Point(8, 23);
            this.lstBlackListIngredient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBlackListIngredient.Name = "lstBlackListIngredient";
            this.lstBlackListIngredient.Size = new System.Drawing.Size(193, 436);
            this.lstBlackListIngredient.TabIndex = 0;
            this.lstBlackListIngredient.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstBlackListIngredient_DragDrop);
            this.lstBlackListIngredient.DragOver += new System.Windows.Forms.DragEventHandler(this.lstBlackListIngredient_DragOver);
            // 
            // BlackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1096, 624);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BlackList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BlackList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBlackListProduct;
        private System.Windows.Forms.Button BtnSilUrun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSilIcerik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBlackListIngredient;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}