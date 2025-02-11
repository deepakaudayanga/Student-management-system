namespace Login_And_Registration_System
{
    partial class RStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RStaff));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textLName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textPostel = new System.Windows.Forms.TextBox();
            this.textBirthDay = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textFName = new System.Windows.Forms.TextBox();
            this.textGender = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSeach = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnAdd_Click = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.pictureBox1.Image = global::Login_And_Registration_System.Properties.Resources.next1;
            this.pictureBox1.Location = new System.Drawing.Point(291, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(52, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "Staff Count :";
            // 
            // textPhone
            // 
            this.textPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.Location = new System.Drawing.Point(165, 365);
            this.textPhone.Multiline = true;
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(163, 33);
            this.textPhone.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(249, 548);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "0";
            // 
            // textLName
            // 
            this.textLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLName.Location = new System.Drawing.Point(165, 246);
            this.textLName.Multiline = true;
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(163, 33);
            this.textLName.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Birth Day";
            // 
            // textPostel
            // 
            this.textPostel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPostel.Location = new System.Drawing.Point(165, 326);
            this.textPostel.Multiline = true;
            this.textPostel.Name = "textPostel";
            this.textPostel.Size = new System.Drawing.Size(163, 33);
            this.textPostel.TabIndex = 10;
            // 
            // textBirthDay
            // 
            this.textBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBirthDay.Location = new System.Drawing.Point(165, 463);
            this.textBirthDay.Multiline = true;
            this.textBirthDay.Name = "textBirthDay";
            this.textBirthDay.Size = new System.Drawing.Size(163, 33);
            this.textBirthDay.TabIndex = 8;
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(165, 285);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(163, 33);
            this.textAddress.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gender";
            // 
            // textFName
            // 
            this.textFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFName.Location = new System.Drawing.Point(165, 207);
            this.textFName.Multiline = true;
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(163, 33);
            this.textFName.TabIndex = 12;
            // 
            // textGender
            // 
            this.textGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGender.Location = new System.Drawing.Point(165, 412);
            this.textGender.Multiline = true;
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(163, 33);
            this.textGender.TabIndex = 8;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(165, 161);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(163, 33);
            this.textID.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textPhone);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textLName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textPostel);
            this.panel2.Controls.Add(this.textBirthDay);
            this.panel2.Controls.Add(this.textAddress);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textFName);
            this.panel2.Controls.Add(this.textGender);
            this.panel2.Controls.Add(this.textID);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 597);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.textSeach);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BtnAdd_Click);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 100);
            this.panel1.TabIndex = 0;
            // 
            // textSeach
            // 
            this.textSeach.Location = new System.Drawing.Point(765, 44);
            this.textSeach.Multiline = true;
            this.textSeach.Name = "textSeach";
            this.textSeach.Size = new System.Drawing.Size(126, 37);
            this.textSeach.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSearch.Location = new System.Drawing.Point(897, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 43);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.button5.Location = new System.Drawing.Point(572, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 57);
            this.button5.TabIndex = 8;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.button4.Location = new System.Drawing.Point(392, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 57);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete Staff";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.button3.Location = new System.Drawing.Point(213, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 57);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update Staff";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnAdd_Click
            // 
            this.BtnAdd_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.BtnAdd_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd_Click.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.BtnAdd_Click.Location = new System.Drawing.Point(32, 24);
            this.BtnAdd_Click.Name = "BtnAdd_Click";
            this.BtnAdd_Click.Size = new System.Drawing.Size(162, 57);
            this.BtnAdd_Click.TabIndex = 11;
            this.BtnAdd_Click.Text = "Add New Staff";
            this.BtnAdd_Click.UseVisualStyleBackColor = false;
            this.BtnAdd_Click.Click += new System.EventHandler(this.BtnAdd_Click_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Phone Num";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 507);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Postel Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // RStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 597);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RStaff";
            this.Text = "RStaff";
            this.Load += new System.EventHandler(this.RStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPostel;
        private System.Windows.Forms.TextBox textBirthDay;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.TextBox textGender;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textSeach;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnAdd_Click;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}