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
    public partial class Frm_Register : Form
    {
        public Frm_Register()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("provider=microsoft.jet.OLEDB.4.0; Data Source=DB_Users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowpassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtCompassword.PasswordChar = '\0';
            }
            else
            {
               txtPassword.PasswordChar = '*';
                txtCompassword.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FormLoggin().Show();
            this.Hide();
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {

        }

        private void Registation_Click(object sender, EventArgs e)
        {
             if (txtUsername.Text =="" && txtPassword.Text =="" && txtCompassword.Text=="")
            {
                MessageBox.Show("User Name and Password fields are empty", "Registation Faild", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtCompassword.Text)
            {
                con.Open();
                string register ="INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "')";
                    cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtCompassword.Text = "";


                MessageBox.Show("Your Account has been Successfully Created", " Registation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("passwords does not math, Pleace Re-Enter", " Registation Faild ", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtCompassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtCompassword.Text = "";
            txtUsername.Focus();
        }
    }
}
