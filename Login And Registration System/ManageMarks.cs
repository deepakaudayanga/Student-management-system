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
    public partial class ManageMarks : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adepter;
        DataTable dt;
        public ManageMarks()
        {
            InitializeComponent();
        }
        void Getmarks()
        {
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = MarksT.accdb");
            dt = new DataTable();
            adepter = new OleDbDataAdapter("SELECT *FROM marks", conn);
            conn.Open();
            adepter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void ManageMarks_Load(object sender, EventArgs e)
        {
            Getmarks();
        }
    }
}
