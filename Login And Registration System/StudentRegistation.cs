using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Login_And_Registration_System
{
    public partial class StudentRegistation : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adepter;
        DataTable dt;

        public StudentRegistation()
        {
           
            InitializeComponent();
           

        }
        void Getstudents()
        {
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = StudentT.accdb");
            dt = new DataTable();
            adepter = new OleDbDataAdapter("SELECT *FROM student", conn);
            conn.Open();
            adepter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StudentRegistation_Load(object sender, EventArgs e)
        {
            Getstudents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO student (StudentID, FristName, LastName,Phone, Birthday, Gender, Address) VALUES" + "(@id, @fname,@lname,@phone,@birthday,@gender,@address)";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", txtStudentid.Text);
            cmd.Parameters.AddWithValue("@fname", txtFname.Text);
            cmd.Parameters.AddWithValue("@lname", txtLname.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@gender", comGender.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add New Student Successfully");
            Getstudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void raidMale_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void radFemail_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtStudentid.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            comGender.Text = "";
            dateTimePicker1.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
