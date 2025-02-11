namespace Login_And_Registration_System
{
    partial class FormLoggin
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Loggin = new System.Windows.Forms.Button();
            this.checkBoxShowpasswordlog = new System.Windows.Forms.CheckBox();
            this.txtpasswordlog = new System.Windows.Forms.TextBox();
            this.txtUsernamelog = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(104, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Create Account";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Don\'t  Have an Acount";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Location = new System.Drawing.Point(36, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loggin
            // 
            this.Loggin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Loggin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loggin.FlatAppearance.BorderSize = 0;
            this.Loggin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loggin.ForeColor = System.Drawing.Color.White;
            this.Loggin.Location = new System.Drawing.Point(36, 358);
            this.Loggin.Name = "Loggin";
            this.Loggin.Size = new System.Drawing.Size(216, 35);
            this.Loggin.TabIndex = 17;
            this.Loggin.Text = "LOGIN";
            this.Loggin.UseVisualStyleBackColor = false;
            this.Loggin.Click += new System.EventHandler(this.Loggin_Click);
            // 
            // checkBoxShowpasswordlog
            // 
            this.checkBoxShowpasswordlog.AutoSize = true;
            this.checkBoxShowpasswordlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowpasswordlog.Location = new System.Drawing.Point(130, 305);
            this.checkBoxShowpasswordlog.Name = "checkBoxShowpasswordlog";
            this.checkBoxShowpasswordlog.Size = new System.Drawing.Size(122, 21);
            this.checkBoxShowpasswordlog.TabIndex = 15;
            this.checkBoxShowpasswordlog.Text = "Show Password";
            this.checkBoxShowpasswordlog.UseVisualStyleBackColor = true;
            this.checkBoxShowpasswordlog.CheckedChanged += new System.EventHandler(this.checkBoxShowpasswordlog_CheckedChanged);
            // 
            // txtpasswordlog
            // 
            this.txtpasswordlog.BackColor = System.Drawing.Color.Gainsboro;
            this.txtpasswordlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpasswordlog.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswordlog.Location = new System.Drawing.Point(36, 242);
            this.txtpasswordlog.Multiline = true;
            this.txtpasswordlog.Name = "txtpasswordlog";
            this.txtpasswordlog.PasswordChar = '*';
            this.txtpasswordlog.Size = new System.Drawing.Size(216, 28);
            this.txtpasswordlog.TabIndex = 13;
            this.txtpasswordlog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUsernamelog
            // 
            this.txtUsernamelog.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUsernamelog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernamelog.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernamelog.Location = new System.Drawing.Point(36, 174);
            this.txtUsernamelog.Multiline = true;
            this.txtUsernamelog.Name = "txtUsernamelog";
            this.txtUsernamelog.Size = new System.Drawing.Size(216, 28);
            this.txtUsernamelog.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(33, 222);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(66, 17);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(31, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Get Started";
            // 
            // FormLoggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 595);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Loggin);
            this.Controls.Add(this.checkBoxShowpasswordlog);
            this.Controls.Add(this.txtpasswordlog);
            this.Controls.Add(this.txtUsernamelog);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLoggin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoggin";
            this.Load += new System.EventHandler(this.FormLoggin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Loggin;
        private System.Windows.Forms.CheckBox checkBoxShowpasswordlog;
        private System.Windows.Forms.TextBox txtpasswordlog;
        private System.Windows.Forms.TextBox txtUsernamelog;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}