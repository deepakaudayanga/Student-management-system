namespace Login_And_Registration_System
{
    partial class Frm_Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.hjk = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompassword = new System.Windows.Forms.TextBox();
            this.checkBoxShowpassword = new System.Windows.Forms.CheckBox();
            this.Registation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Get Started";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(33, 145);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 28);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hjk
            // 
            this.hjk.AutoSize = true;
            this.hjk.Location = new System.Drawing.Point(30, 193);
            this.hjk.Name = "hjk";
            this.hjk.Size = new System.Drawing.Size(66, 17);
            this.hjk.TabIndex = 2;
            this.hjk.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(33, 213);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Confirm Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCompassword
            // 
            this.txtCompassword.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCompassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompassword.Location = new System.Drawing.Point(33, 277);
            this.txtCompassword.Multiline = true;
            this.txtCompassword.Name = "txtCompassword";
            this.txtCompassword.PasswordChar = '*';
            this.txtCompassword.Size = new System.Drawing.Size(216, 28);
            this.txtCompassword.TabIndex = 3;
            this.txtCompassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBoxShowpassword
            // 
            this.checkBoxShowpassword.AutoSize = true;
            this.checkBoxShowpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowpassword.Location = new System.Drawing.Point(131, 321);
            this.checkBoxShowpassword.Name = "checkBoxShowpassword";
            this.checkBoxShowpassword.Size = new System.Drawing.Size(122, 21);
            this.checkBoxShowpassword.TabIndex = 4;
            this.checkBoxShowpassword.Text = "Show Password";
            this.checkBoxShowpassword.UseVisualStyleBackColor = true;
            this.checkBoxShowpassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Registation
            // 
            this.Registation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Registation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registation.FlatAppearance.BorderSize = 0;
            this.Registation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registation.ForeColor = System.Drawing.Color.White;
            this.Registation.Location = new System.Drawing.Point(37, 374);
            this.Registation.Name = "Registation";
            this.Registation.Size = new System.Drawing.Size(216, 35);
            this.Registation.TabIndex = 5;
            this.Registation.Text = "REGISTER";
            this.Registation.UseVisualStyleBackColor = false;
            this.Registation.Click += new System.EventHandler(this.Registation_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Location = new System.Drawing.Point(37, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alredy I Have an Acount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(105, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Back to LOGIN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 595);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Registation);
            this.Controls.Add(this.checkBoxShowpassword);
            this.Controls.Add(this.txtCompassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hjk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(155)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label hjk;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompassword;
        private System.Windows.Forms.CheckBox checkBoxShowpassword;
        private System.Windows.Forms.Button Registation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

