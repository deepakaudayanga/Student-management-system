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
    public partial class FormLoggin : Form
    {
        public FormLoggin()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("provider=microsoft.jet.OLEDB.4.0; Data Source=DB_Users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void FormLoggin_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Frm_Register().Show();
            this.Hide();
        }

        private void Loggin_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username='" + txtUsernamelog.Text + "' and password='" + txtpasswordlog.Text + "' ";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new loadingFrm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsernamelog.Text = "";
                txtpasswordlog.Text = "";
                txtUsernamelog.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsernamelog.Text = "";
            txtpasswordlog.Text = "";
            txtUsernamelog.Focus();
        }

        private void checkBoxShowpasswordlog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowpasswordlog.Checked)
            {
                txtpasswordlog.UseSystemPasswordChar = true;
            }
            else
            {
                txtpasswordlog.UseSystemPasswordChar = false;
            }

        }
    }
}