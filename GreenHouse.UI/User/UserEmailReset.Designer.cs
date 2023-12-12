namespace GreenHouse.UI.User
{
    partial class UserEmailReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEmailReset));
            this.gbPasswordReset = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtOldEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbPasswordReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPasswordReset
            // 
            this.gbPasswordReset.Controls.Add(this.txtPassword);
            this.gbPasswordReset.Controls.Add(this.label2);
            this.gbPasswordReset.Controls.Add(this.txtNewEmail);
            this.gbPasswordReset.Controls.Add(this.label1);
            this.gbPasswordReset.Controls.Add(this.button2);
            this.gbPasswordReset.Controls.Add(this.txtOldEmail);
            this.gbPasswordReset.Controls.Add(this.label6);
            this.gbPasswordReset.Location = new System.Drawing.Point(16, 15);
            this.gbPasswordReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPasswordReset.Name = "gbPasswordReset";
            this.gbPasswordReset.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPasswordReset.Size = new System.Drawing.Size(311, 386);
            this.gbPasswordReset.TabIndex = 1;
            this.gbPasswordReset.TabStop = false;
            this.gbPasswordReset.Text = "Email Yenileme";
            this.gbPasswordReset.Enter += new System.EventHandler(this.gbPasswordReset_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(137, 135);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(152, 22);
            this.txtPassword.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Şifre:";
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(137, 87);
            this.txtNewEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(152, 22);
            this.txtNewEmail.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Yeni Email:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 190);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Email Değiştir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtOldEmail
            // 
            this.txtOldEmail.Location = new System.Drawing.Point(137, 55);
            this.txtOldEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOldEmail.Name = "txtOldEmail";
            this.txtOldEmail.Size = new System.Drawing.Size(152, 22);
            this.txtOldEmail.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = " Eski Email:";
            // 
            // UserEmailReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(353, 423);
            this.Controls.Add(this.gbPasswordReset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserEmailReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbPasswordReset.ResumeLayout(false);
            this.gbPasswordReset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPasswordReset;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtOldEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
    }
}