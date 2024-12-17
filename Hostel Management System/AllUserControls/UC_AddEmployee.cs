using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.AllUserControls
{
    public partial class UC_AddEmployee : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddEmployee()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPG (*.jpg)|*.jpg*|JPEG (*.jpeg)|*.jpeg*|PNG (*.png)|*.png*|All File(*.*)|*.*";
            if(op.ShowDialog() == DialogResult.OK )
            {
                pictureBox.Image= new Bitmap(op.FileName);
                imagepath.Text= op.FileName;
            }
        }

        private void UC_AddEmployee_Load(object sender, EventArgs e)
        {
            txtdesignation.SelectedIndex = 0;
            imagepath.Visible = false;
            fillData();

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtFName.Text !="" && txtMobileNo.Text !="")
            {

                string name = txtName.Text;
                string fname = txtFName.Text;
                Int64 mobile = Int64.Parse(txtMobileNo.Text);
                Int64 idproof = Int64.Parse(txtIdProof.Text);
                string address = txtAddress.Text;
                string uniqueid = txtUniqueID.Text;
                string email = txtEmailID.Text;
                string designation = txtdesignation.Text;
                string image = imagepath.Text;



                query = "insert into NewEmployee (Name,FatherName,MobileNo,IDProof,Address,UniqueID,Email,Designation,Image) values ('" + name + "','" + fname + "'," + mobile + "," + idproof + ",'" + address + "','" + uniqueid + "','" + email + "','" + designation + "','" + image + "')";
                fn.setData(query, "Add Employee Successfully.");
                fillData();
            }

        }
        protected void fillData()
        {
            query = "select * from NewEmployee";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
