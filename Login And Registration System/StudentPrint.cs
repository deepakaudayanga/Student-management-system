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
    public partial class StudentPrint : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adepter;
        DataTable dt;

        public StudentPrint()
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

        private void StudentPrint_Load(object sender, EventArgs e)
        {
            Getstudents();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                String.Format(" StudentID like '%" + txtSearch.Text + "%'");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 0.8;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }
    }
}
