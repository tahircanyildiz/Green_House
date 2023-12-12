namespace GreenHouse.UI.User
{
    partial class ProductContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductContent));
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSolIndex = new System.Windows.Forms.Button();
            this.BtnSagIndex = new System.Windows.Forms.Button();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.rchProductIngredientsDetails = new System.Windows.Forms.RichTextBox();
            this.rchAddedByCustomer = new System.Windows.Forms.RichTextBox();
            this.lstProductIngredients = new System.Windows.Forms.ListBox();
            this.lblRisksiz = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAzRiskli = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOrtaRiskli = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblYüksekRiskli = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCokRiskli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbProduct
            // 
            this.pbProduct.Image = ((System.Drawing.Image)(resources.GetObject("pbProduct.Image")));
            this.pbProduct.Location = new System.Drawing.Point(8, 23);
            this.pbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(179, 138);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduct.TabIndex = 0;
            this.pbProduct.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::GreenHouse.UI.Properties.Resources.Green_Illustrative_Organic_Plant_Zoom_Virtual_Background;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.BtnSolIndex);
            this.groupBox1.Controls.Add(this.BtnSagIndex);
            this.groupBox1.Controls.Add(this.lblUrun);
            this.groupBox1.Controls.Add(this.lblKategori);
            this.groupBox1.Controls.Add(this.rchProductIngredientsDetails);
            this.groupBox1.Controls.Add(this.rchAddedByCustomer);
            this.groupBox1.Controls.Add(this.lstProductIngredients);
            this.groupBox1.Controls.Add(this.lblRisksiz);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblAzRiskli);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblOrtaRiskli);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblYüksekRiskli);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCokRiskli);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.pbProduct);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(785, 442);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün";
            // 
            // BtnSolIndex
            // 
            this.BtnSolIndex.Location = new System.Drawing.Point(44, 226);
            this.BtnSolIndex.Name = "BtnSolIndex";
            this.BtnSolIndex.Size = new System.Drawing.Size(38, 31);
            this.BtnSolIndex.TabIndex = 21;
            this.BtnSolIndex.Text = "<";
            this.BtnSolIndex.UseVisualStyleBackColor = true;
            this.BtnSolIndex.Click += new System.EventHandler(this.BtnSolIndex_Click);
            // 
            // BtnSagIndex
            // 
            this.BtnSagIndex.Location = new System.Drawing.Point(110, 226);
            this.BtnSagIndex.Name = "BtnSagIndex";
            this.BtnSagIndex.Size = new System.Drawing.Size(38, 31);
            this.BtnSagIndex.TabIndex = 20;
            this.BtnSagIndex.Text = ">";
            this.BtnSagIndex.UseVisualStyleBackColor = true;
            this.BtnSagIndex.Click += new System.EventHandler(this.BtnSagIndex_Click);
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(315, 60);
            this.lblUrun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(58, 16);
            this.lblUrun.TabIndex = 17;
            this.lblUrun.Text = "Ürün Adı";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(315, 23);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(57, 16);
            this.lblKategori.TabIndex = 16;
            this.lblKategori.Text = "Kategori";
            // 
            // rchProductIngredientsDetails
            // 
            this.rchProductIngredientsDetails.Enabled = false;
            this.rchProductIngredientsDetails.Location = new System.Drawing.Point(447, 276);
            this.rchProductIngredientsDetails.Margin = new System.Windows.Forms.Padding(4);
            this.rchProductIngredientsDetails.Name = "rchProductIngredientsDetails";
            this.rchProductIngredientsDetails.Size = new System.Drawing.Size(296, 127);
            this.rchProductIngredientsDetails.TabIndex = 15;
            this.rchProductIngredientsDetails.Text = "";
            // 
            // rchAddedByCustomer
            // 
            this.rchAddedByCustomer.Enabled = false;
            this.rchAddedByCustomer.Location = new System.Drawing.Point(10, 287);
            this.rchAddedByCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.rchAddedByCustomer.Name = "rchAddedByCustomer";
            this.rchAddedByCustomer.Size = new System.Drawing.Size(177, 63);
            this.rchAddedByCustomer.TabIndex = 14;
            this.rchAddedByCustomer.Text = "";
            // 
            // lstProductIngredients
            // 
            this.lstProductIngredients.ForeColor = System.Drawing.Color.Red;
            this.lstProductIngredients.FormattingEnabled = true;
            this.lstProductIngredients.ItemHeight = 16;
            this.lstProductIngredients.Location = new System.Drawing.Point(447, 23);
            this.lstProductIngredients.Margin = new System.Windows.Forms.Padding(4);
            this.lstProductIngredients.Name = "lstProductIngredients";
            this.lstProductIngredients.Size = new System.Drawing.Size(296, 244);
            this.lstProductIngredients.TabIndex = 13;
            this.lstProductIngredients.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstProductIngredients_DrawItem);
            this.lstProductIngredients.SelectedIndexChanged += new System.EventHandler(this.lstProductIngredients_SelectedIndexChanged);
            // 
            // lblRisksiz
            // 
            this.lblRisksiz.AutoSize = true;
            this.lblRisksiz.Location = new System.Drawing.Point(409, 241);
            this.lblRisksiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRisksiz.Name = "lblRisksiz";
            this.lblRisksiz.Size = new System.Drawing.Size(14, 16);
            this.lblRisksiz.TabIndex = 12;
            this.lblRisksiz.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Temiz İçerikler:";
            // 
            // lblAzRiskli
            // 
            this.lblAzRiskli.AutoSize = true;
            this.lblAzRiskli.Location = new System.Drawing.Point(409, 209);
            this.lblAzRiskli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAzRiskli.Name = "lblAzRiskli";
            this.lblAzRiskli.Size = new System.Drawing.Size(14, 16);
            this.lblAzRiskli.TabIndex = 10;
            this.lblAzRiskli.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Az Riskli İçerikler:";
            // 
            // lblOrtaRiskli
            // 
            this.lblOrtaRiskli.AutoSize = true;
            this.lblOrtaRiskli.Location = new System.Drawing.Point(409, 177);
            this.lblOrtaRiskli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrtaRiskli.Name = "lblOrtaRiskli";
            this.lblOrtaRiskli.Size = new System.Drawing.Size(14, 16);
            this.lblOrtaRiskli.TabIndex = 8;
            this.lblOrtaRiskli.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Orta Riskli İçerikler:";
            // 
            // lblYüksekRiskli
            // 
            this.lblYüksekRiskli.AutoSize = true;
            this.lblYüksekRiskli.Location = new System.Drawing.Point(409, 145);
            this.lblYüksekRiskli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYüksekRiskli.Name = "lblYüksekRiskli";
            this.lblYüksekRiskli.Size = new System.Drawing.Size(14, 16);
            this.lblYüksekRiskli.TabIndex = 6;
            this.lblYüksekRiskli.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Riskli İçerikler:";
            // 
            // lblCokRiskli
            // 
            this.lblCokRiskli.AutoSize = true;
            this.lblCokRiskli.Location = new System.Drawing.Point(409, 116);
            this.lblCokRiskli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCokRiskli.Name = "lblCokRiskli";
            this.lblCokRiskli.Size = new System.Drawing.Size(14, 16);
            this.lblCokRiskli.TabIndex = 4;
            this.lblCokRiskli.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kara Listedeki İçerikler:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(229, 60);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(58, 16);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(229, 23);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 16);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Kategori";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ProductContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(787, 441);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductContent";
            this.Load += new System.EventHandler(this.ProductContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblRisksiz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAzRiskli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOrtaRiskli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblYüksekRiskli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCokRiskli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ListBox lstProductIngredients;
        private System.Windows.Forms.RichTextBox rchAddedByCustomer;
        private System.Windows.Forms.RichTextBox rchProductIngredientsDetails;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button BtnSolIndex;
        private System.Windows.Forms.Button BtnSagIndex;
        private System.Windows.Forms.ImageList ımageList1;
    }
}