namespace Program_1
{
    partial class frmRegister
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
            this.txtLinkLogin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bnRegister = new System.Windows.Forms.Button();
            this.checkBxShPassw = new System.Windows.Forms.CheckBox();
            this.txtBxConfPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLinkLogin
            // 
            this.txtLinkLogin.AutoSize = true;
            this.txtLinkLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLinkLogin.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtLinkLogin.Location = new System.Drawing.Point(212, 416);
            this.txtLinkLogin.Name = "txtLinkLogin";
            this.txtLinkLogin.Size = new System.Drawing.Size(60, 23);
            this.txtLinkLogin.TabIndex = 22;
            this.txtLinkLogin.Text = "Log in";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(59, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Have an account?";
            // 
            // bnRegister
            // 
            this.bnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.bnRegister.FlatAppearance.BorderSize = 0;
            this.bnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnRegister.ForeColor = System.Drawing.Color.White;
            this.bnRegister.Location = new System.Drawing.Point(57, 365);
            this.bnRegister.Name = "bnRegister";
            this.bnRegister.Size = new System.Drawing.Size(243, 44);
            this.bnRegister.TabIndex = 20;
            this.bnRegister.Text = "REGISTER";
            this.bnRegister.UseVisualStyleBackColor = false;
            this.bnRegister.Click += new System.EventHandler(this.bnRegister_Click);
            // 
            // checkBxShPassw
            // 
            this.checkBxShPassw.AutoSize = true;
            this.checkBxShPassw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBxShPassw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBxShPassw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBxShPassw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBxShPassw.Location = new System.Drawing.Point(57, 313);
            this.checkBxShPassw.Name = "checkBxShPassw";
            this.checkBxShPassw.Size = new System.Drawing.Size(136, 24);
            this.checkBxShPassw.TabIndex = 19;
            this.checkBxShPassw.Text = "Show password";
            this.checkBxShPassw.UseVisualStyleBackColor = true;
            this.checkBxShPassw.CheckedChanged += new System.EventHandler(this.checkBxShPassw_CheckedChanged);
            // 
            // txtBxConfPassword
            // 
            this.txtBxConfPassword.BackColor = System.Drawing.Color.Lavender;
            this.txtBxConfPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxConfPassword.Location = new System.Drawing.Point(57, 274);
            this.txtBxConfPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBxConfPassword.Multiline = true;
            this.txtBxConfPassword.Name = "txtBxConfPassword";
            this.txtBxConfPassword.PasswordChar = '*';
            this.txtBxConfPassword.Size = new System.Drawing.Size(243, 33);
            this.txtBxConfPassword.TabIndex = 18;
            this.txtBxConfPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxConfPassword_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(54, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirm password";
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.BackColor = System.Drawing.Color.Lavender;
            this.txtBxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxPassword.Location = new System.Drawing.Point(57, 200);
            this.txtBxPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBxPassword.Multiline = true;
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(243, 33);
            this.txtBxPassword.TabIndex = 16;
            this.txtBxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxPassword_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(54, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.BackColor = System.Drawing.Color.Lavender;
            this.txtBxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxUsername.Location = new System.Drawing.Point(57, 126);
            this.txtBxUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBxUsername.Multiline = true;
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(243, 33);
            this.txtBxUsername.TabIndex = 14;
            this.txtBxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxUsername_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(54, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registration";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(350, 468);
            this.Controls.Add(this.txtLinkLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bnRegister);
            this.Controls.Add(this.checkBxShPassw);
            this.Controls.Add(this.txtBxConfPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLinkLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bnRegister;
        private System.Windows.Forms.CheckBox checkBxShPassw;
        private System.Windows.Forms.TextBox txtBxConfPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

