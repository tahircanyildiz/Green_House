namespace GreenHouse.UI.User
{
    partial class UserPasswordReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPasswordReset));
            this.gbPasswordReset = new System.Windows.Forms.GroupBox();
            this.txtnewPasswordAgain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtOldPasssword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbPasswordReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPasswordReset
            // 
            this.gbPasswordReset.Controls.Add(this.txtnewPasswordAgain);
            this.gbPasswordReset.Controls.Add(this.label2);
            this.gbPasswordReset.Controls.Add(this.txtNewPassword);
            this.gbPasswordReset.Controls.Add(this.label1);
            this.gbPasswordReset.Controls.Add(this.button2);
            this.gbPasswordReset.Controls.Add(this.txtOldPasssword);
            this.gbPasswordReset.Controls.Add(this.label6);
            this.gbPasswordReset.Location = new System.Drawing.Point(16, 15);
            this.gbPasswordReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPasswordReset.Name = "gbPasswordReset";
            this.gbPasswordReset.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPasswordReset.Size = new System.Drawing.Size(311, 386);
            this.gbPasswordReset.TabIndex = 0;
            this.gbPasswordReset.TabStop = false;
            this.gbPasswordReset.Text = "Şifre Yenileme";
            // 
            // txtnewPasswordAgain
            // 
            this.txtnewPasswordAgain.Location = new System.Drawing.Point(137, 119);
            this.txtnewPasswordAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnewPasswordAgain.Name = "txtnewPasswordAgain";
            this.txtnewPasswordAgain.PasswordChar = '*';
            this.txtnewPasswordAgain.Size = new System.Drawing.Size(152, 22);
            this.txtnewPasswordAgain.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Yeni Şifre Tekrar:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(137, 87);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(152, 22);
            this.txtNewPassword.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Yeni Şifre:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 191);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Şifre Değiştir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtOldPasssword
            // 
            this.txtOldPasssword.Location = new System.Drawing.Point(137, 55);
            this.txtOldPasssword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOldPasssword.Name = "txtOldPasssword";
            this.txtOldPasssword.PasswordChar = '*';
            this.txtOldPasssword.Size = new System.Drawing.Size(152, 22);
            this.txtOldPasssword.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = " Eski Şifre:";
            // 
            // UserPasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(388, 436);
            this.Controls.Add(this.gbPasswordReset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserPasswordReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserPasswordReset_Load);
            this.gbPasswordReset.ResumeLayout(false);
            this.gbPasswordReset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPasswordReset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtOldPasssword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnewPasswordAgain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label1;
    }
}