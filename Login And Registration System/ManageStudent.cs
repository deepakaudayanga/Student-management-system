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
    public partial class ManageStudent : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adepter;
        DataTable dt;

        public ManageStudent()
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
        private void ManageStudent_Load(object sender, EventArgs e)
        {
            Getstudents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE student  SET StudentID=@id, FristName=@fname, LastName=@lname,Phone=@phone, Birthday=@birthday, Gender=@gender, Address=@address WHERE StudentID=@id ";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", txtstudentID.Text);
            cmd.Parameters.AddWithValue("@fname", txtFname.Text);
            cmd.Parameters.AddWithValue("@lname", txtLname.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@gender", comGender.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToString(txtstudentID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Student Successfully");
            Getstudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM student WHERE StudentID=@id";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToString(txtstudentID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("DELETE Student Successfully");
            Getstudents();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtstudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comGender.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
