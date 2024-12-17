using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
        Boolean lablevisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lablevisible == true)
            {
                hmlabel.Visible=true;
                lablevisible= false;
            }
            else
            {
                hmlabel.Visible=false;
                lablevisible = true;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true;
            timer1.Start();
            uC_AddRoom1.Visible=false;
            uC_AddStudent1.Visible = false;
            uC_UpdateandDeleteStudent1.Visible=false;
            uC_StudentFees1.Visible=false;
            uC_AllStudentDetail1.Visible = false;
            uC_Checkout1.Visible = false;
            uC_AddEmployee1.Visible = false;
        }

        private void btnAddR_Click(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible=true;
            uC_AddRoom1.BringToFront();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            uC_AddStudent1.Visible = true;
            uC_AddStudent1.BringToFront();
        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            uC_UpdateandDeleteStudent1.Visible= true;
            uC_UpdateandDeleteStudent1.BringToFront();
        }

        private void btnStudentFee_Click(object sender, EventArgs e)
        {
            uC_StudentFees1.Visible = true;
            uC_StudentFees1.BringToFront();
        }

        private void btnStudentDetail_Click(object sender, EventArgs e)
        {
            uC_AllStudentDetail1.Visible = true;
            uC_AllStudentDetail1.BringToFront();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            uC_Checkout1.Visible = true;
            uC_Checkout1.BringToFront();

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            uC_AddEmployee1.Visible = true;
            uC_AddEmployee1.BringToFront();
        }
    }
}
