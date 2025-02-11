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
    public partial class student : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Udayanga\Documents\St.accdb");
        public student()
        {
            InitializeComponent();
        }
        void dataviewer()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " select *from student";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void student_Load(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert Into Student(StudentID,FristName,LastName,Address,PostelCode,PhoneNum) Values ('" + textID.Text + "', '" + textFName.Text + "','" + textLName.Text + "','" + textAddress.Text + "','" + textPostel.Text + "','" + textPhone.Text + "'  )";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Recode Save ", " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " update student set StudentID = '"+ textID.Text + "' where FristName = '" + textFName.Text + "' and LastName ='" + textLName.Text + "' ";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Recode Update ", " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show(" Confrim if you want to Exit ", " access connect ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textAddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textPostel.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textPhone.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
