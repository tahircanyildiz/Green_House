
namespace GreenHouse.UI.AdminPanel.UI
{
    partial class AdminMenuElemanUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMenuEleman = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMenulerME = new System.Windows.Forms.ComboBox();
            this.cmbElemanlarME = new System.Windows.Forms.ComboBox();
            this.lstMenuElemanları = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuElemanSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkleMenuEleman = new System.Windows.Forms.Button();
            this.tpElemanMenu = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkleElemanMenu = new System.Windows.Forms.Button();
            this.cmbMenulerEM = new System.Windows.Forms.ComboBox();
            this.lstElemanMenuleri = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.elemanMenuSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbElemanlarEM = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpMenuEleman.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tpElemanMenu.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMenuEleman);
            this.tabControl1.Controls.Add(this.tpElemanMenu);
            this.tabControl1.Location = new System.Drawing.Point(182, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(342, 400);
            this.tabControl1.TabIndex = 42;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpMenuEleman
            // 
            this.tpMenuEleman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.tpMenuEleman.Controls.Add(this.label2);
            this.tpMenuEleman.Controls.Add(this.cmbMenulerME);
            this.tpMenuEleman.Controls.Add(this.cmbElemanlarME);
            this.tpMenuEleman.Controls.Add(this.lstMenuElemanları);
            this.tpMenuEleman.Controls.Add(this.label1);
            this.tpMenuEleman.Controls.Add(this.btnEkleMenuEleman);
            this.tpMenuEleman.Location = new System.Drawing.Point(4, 22);
            this.tpMenuEleman.Name = "tpMenuEleman";
            this.tpMenuEleman.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenuEleman.Size = new System.Drawing.Size(334, 374);
            this.tpMenuEleman.TabIndex = 0;
            this.tpMenuEleman.Text = "Menu-Eleman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Menu Adı :";
            // 
            // cmbMenulerME
            // 
            this.cmbMenulerME.FormattingEnabled = true;
            this.cmbMenulerME.Location = new System.Drawing.Point(118, 17);
            this.cmbMenulerME.Name = "cmbMenulerME";
            this.cmbMenulerME.Size = new System.Drawing.Size(203, 21);
            this.cmbMenulerME.TabIndex = 7;
            this.cmbMenulerME.SelectedIndexChanged += new System.EventHandler(this.cmbMenulerME_SelectedIndexChanged);
            // 
            // cmbElemanlarME
            // 
            this.cmbElemanlarME.FormattingEnabled = true;
            this.cmbElemanlarME.Location = new System.Drawing.Point(118, 58);
            this.cmbElemanlarME.Name = "cmbElemanlarME";
            this.cmbElemanlarME.Size = new System.Drawing.Size(203, 21);
            this.cmbElemanlarME.TabIndex = 9;
            // 
            // lstMenuElemanları
            // 
            this.lstMenuElemanları.ContextMenuStrip = this.contextMenuStrip1;
            this.lstMenuElemanları.FormattingEnabled = true;
            this.lstMenuElemanları.Location = new System.Drawing.Point(12, 132);
            this.lstMenuElemanları.Name = "lstMenuElemanları";
            this.lstMenuElemanları.Size = new System.Drawing.Size(313, 225);
            this.lstMenuElemanları.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuElemanSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 26);
            // 
            // menuElemanSilToolStripMenuItem
            // 
            this.menuElemanSilToolStripMenuItem.Name = "menuElemanSilToolStripMenuItem";
            this.menuElemanSilToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.menuElemanSilToolStripMenuItem.Text = "MenuElemanSil";
            this.menuElemanSilToolStripMenuItem.Click += new System.EventHandler(this.menuElemanSilToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Eleman Adı :";
            // 
            // btnEkleMenuEleman
            // 
            this.btnEkleMenuEleman.Location = new System.Drawing.Point(262, 85);
            this.btnEkleMenuEleman.Name = "btnEkleMenuEleman";
            this.btnEkleMenuEleman.Size = new System.Drawing.Size(60, 41);
            this.btnEkleMenuEleman.TabIndex = 27;
            this.btnEkleMenuEleman.Text = "Ekle";
            this.btnEkleMenuEleman.UseVisualStyleBackColor = true;
            this.btnEkleMenuEleman.Click += new System.EventHandler(this.btnEkleMenuEleman_Click);
            // 
            // tpElemanMenu
            // 
            this.tpElemanMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.tpElemanMenu.Controls.Add(this.label4);
            this.tpElemanMenu.Controls.Add(this.label3);
            this.tpElemanMenu.Controls.Add(this.btnEkleElemanMenu);
            this.tpElemanMenu.Controls.Add(this.cmbMenulerEM);
            this.tpElemanMenu.Controls.Add(this.lstElemanMenuleri);
            this.tpElemanMenu.Controls.Add(this.cmbElemanlarEM);
            this.tpElemanMenu.Location = new System.Drawing.Point(4, 22);
            this.tpElemanMenu.Name = "tpElemanMenu";
            this.tpElemanMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpElemanMenu.Size = new System.Drawing.Size(334, 374);
            this.tpElemanMenu.TabIndex = 1;
            this.tpElemanMenu.Text = "Eleman-Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Menu Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-1, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Eleman Adı :";
            // 
            // btnEkleElemanMenu
            // 
            this.btnEkleElemanMenu.Location = new System.Drawing.Point(256, 116);
            this.btnEkleElemanMenu.Name = "btnEkleElemanMenu";
            this.btnEkleElemanMenu.Size = new System.Drawing.Size(60, 41);
            this.btnEkleElemanMenu.TabIndex = 36;
            this.btnEkleElemanMenu.Text = "Ekle";
            this.btnEkleElemanMenu.UseVisualStyleBackColor = true;
            this.btnEkleElemanMenu.Click += new System.EventHandler(this.btnEkleElemanMenu_Click);
            // 
            // cmbMenulerEM
            // 
            this.cmbMenulerEM.FormattingEnabled = true;
            this.cmbMenulerEM.Location = new System.Drawing.Point(113, 67);
            this.cmbMenulerEM.Name = "cmbMenulerEM";
            this.cmbMenulerEM.Size = new System.Drawing.Size(203, 21);
            this.cmbMenulerEM.TabIndex = 32;
            // 
            // lstElemanMenuleri
            // 
            this.lstElemanMenuleri.ContextMenuStrip = this.contextMenuStrip2;
            this.lstElemanMenuleri.FormattingEnabled = true;
            this.lstElemanMenuleri.Location = new System.Drawing.Point(3, 177);
            this.lstElemanMenuleri.Name = "lstElemanMenuleri";
            this.lstElemanMenuleri.Size = new System.Drawing.Size(313, 225);
            this.lstElemanMenuleri.TabIndex = 38;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elemanMenuSilToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(157, 26);
            // 
            // elemanMenuSilToolStripMenuItem
            // 
            this.elemanMenuSilToolStripMenuItem.Name = "elemanMenuSilToolStripMenuItem";
            this.elemanMenuSilToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.elemanMenuSilToolStripMenuItem.Text = "ElemanMenuSil";
            this.elemanMenuSilToolStripMenuItem.Click += new System.EventHandler(this.elemanMenuSilToolStripMenuItem_Click);
            // 
            // cmbElemanlarEM
            // 
            this.cmbElemanlarEM.FormattingEnabled = true;
            this.cmbElemanlarEM.Location = new System.Drawing.Point(113, 31);
            this.cmbElemanlarEM.Name = "cmbElemanlarEM";
            this.cmbElemanlarEM.Size = new System.Drawing.Size(203, 21);
            this.cmbElemanlarEM.TabIndex = 34;
            this.cmbElemanlarEM.SelectedIndexChanged += new System.EventHandler(this.cmbElemanlarEM_SelectedIndexChanged);
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
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminMenuElemanUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(700, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenuElemanUI";
            this.Text = "AdminMenuElemanUI";
            this.Load += new System.EventHandler(this.AdminMenuElemanUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpMenuEleman.ResumeLayout(false);
            this.tpMenuEleman.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tpElemanMenu.ResumeLayout(false);
            this.tpElemanMenu.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMenuEleman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMenulerME;
        private System.Windows.Forms.ComboBox cmbElemanlarME;
        private System.Windows.Forms.ListBox lstMenuElemanları;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkleMenuEleman;
        private System.Windows.Forms.TabPage tpElemanMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkleElemanMenu;
        private System.Windows.Forms.ComboBox cmbMenulerEM;
        private System.Windows.Forms.ListBox lstElemanMenuleri;
        private System.Windows.Forms.ComboBox cmbElemanlarEM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuElemanSilToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem elemanMenuSilToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}