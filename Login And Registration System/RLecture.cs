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
    public partial class RLecture : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = student.accdb");
        int cheker;
        Bitmap bitmap;
        public RLecture()
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

                label10.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert Into Student(StudentID,FristName,LastName,Address,PostelCode,PhoneNum,Gender,BirthDay) Values ('" + textID.Text + "', '" + textFName.Text + "','" + textLName.Text + "','" + textAddress.Text + "','" + textPostel.Text + "','" + textPhone.Text + "','" + textGender.Text + "','" + textBirthDay.Text + "'  )";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Recode Save ", " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
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
                textGender.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBirthDay.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void RStudent_Load(object sender, EventArgs e)
        {
            dataviewer();
            label4.Parent = panel2;
            label4.BackColor = Color.Transparent;
            dataviewer();
            label2.Parent = panel2;
            label2.BackColor = Color.Transparent;
            label3.Parent = panel2;
            label3.BackColor = Color.Transparent;
            label5.Parent = panel2;
            label5.BackColor = Color.Transparent;
            label6.Parent = panel2;
            label6.BackColor = Color.Transparent;
            label7.Parent = panel2;
            label7.BackColor = Color.Transparent;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textAddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textPostel.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textPhone.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textGender.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBirthDay.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " update student set StudentID= '" + textID.Text + "' where FristName= '" + textFName.Text + "'and LastName= '" + textLName.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Recode Updated", " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " delete* from student where StudentID= '" + textID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Recode deleted", " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();

                textID.Text = "";
                textFName.Text = "";
                textLName.Text = "";
                textAddress.Text = "";
                textPostel.Text = "";
                textPhone.Text = "";
                textGender.Text = "";
                textBirthDay.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cheker = 0;
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " select *from student where StudentID= '" + textSeach.Text + "' or FristName='" + textSeach.Text + "' or FristName='" + textSeach.Text + "'  ";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                cheker = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;

                con.Close();
                if (cheker == 0)
                {
                    MessageBox.Show("Recode Not Found", " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textSeach.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textSeach_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textAddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textPostel.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textPhone.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textGender.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBirthDay.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textAddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textPostel.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textPhone.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textGender.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBirthDay.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " access connect ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }

        }
    }
}
