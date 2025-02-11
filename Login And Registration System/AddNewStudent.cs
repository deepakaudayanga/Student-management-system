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
    public partial class AddNewStudent : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Udayanga\Documents\St.accdb");
        public AddNewStudent()
        {
            InitializeComponent();
        }

        private void AddNewStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
