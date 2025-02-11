using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_And_Registration_System
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
            customizedDesign();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }
        private void customizedDesign()
        {
            panelStudent.Visible = false;
            panelCourse.Visible = false;
            panelMarks.Visible = false;
            panelLecture.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelStudent.Visible == true)
                panelStudent.Visible = false;
            if (panelCourse.Visible == true)
                panelCourse.Visible = false;
            if (panelMarks.Visible == true)
                panelMarks.Visible = false;
            if (panelLecture.Visible == true)
                panelLecture.Visible = false;
        }
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelStudent);
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCourse);
        }

        private void btnExamMarks_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMarks);
        }

        private void BtnRegistation_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            this.panelShow.Controls.Clear();
            StudentRegistation SRF = new StudentRegistation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShow.Controls.Add(SRF);
            SRF.Show();

        }

        private void btnManageStu_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            this.panelShow.Controls.Clear();
            ManageStudent SMF = new ManageStudent() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShow.Controls.Add(SMF);
            SMF.Show();

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnPrintSt_Click(object sender, EventArgs e)
        {
            this.panelShow.Controls.Clear();
            StudentPrint SPF = new StudentPrint() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShow.Controls.Add(SPF);
            SPF.Show();

            HideSubMenu();
        }

        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            this.panelShow.Controls.Clear();
            NewCourse NCF = new NewCourse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShow.Controls.Add(NCF);
            NCF.Show();
            HideSubMenu();
           
        }

        private void btnManageCourse_Click(object sender, EventArgs e)
        {

            this.panelShow.Controls.Clear();
            ManageCourse MCF = new ManageCourse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShow.Controls.Add(MCF);
            MCF.Show();
            HideSubMenu();
        }

        private void btnPrintCo_Click(object sender, EventArgs e)
        {
            this.panelShow.Controls.Clear();
            PrintCourse PCF = new PrintCourse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShow.Controls.Add(PCF);
            PCF.Show();
            HideSubMenu();
        }

        private void btnAddMarks_Click(object sender, EventArgs e)
        {

            this.panelShow.Controls.Clear();
           AddMarks AMF = new AddMarks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShow.Controls.Add(AMF);
            AMF.Show();
            HideSubMenu();
        }

        private void btnMangeMarks_Click(object sender, EventArgs e)
        {
            this.panelShow.Controls.Clear();
           ManageMarks MMF = new ManageMarks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShow.Controls.Add(MMF);
            MMF.Show();
            HideSubMenu();
        }

        private void btnPrintMa_Click(object sender, EventArgs e)
        {
            this.panelShow.Controls.Clear();
            PrintMarks PMF = new PrintMarks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShow.Controls.Add(PMF);
            PMF.Show();
          
            HideSubMenu();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.panelShow.Controls.Clear();
            Dashboard DBF = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShow.Controls.Add(DBF);
            DBF.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelLecture);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
