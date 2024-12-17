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
    public partial class UC_UpdateandDeleteStudent : UserControl
    {
        function fn = new function();
        string query;
        public UC_UpdateandDeleteStudent()
        {
            InitializeComponent();
        }

        private void UC_UpdateandDeleteStudent_Load(object sender, EventArgs e)
        {
            loadData();
            txtImagePath.Visible = false;
        }
        public void loadData()
        {
            query = "select * from addStudent";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPG (*.jpg)|*.jpg*|PNG (*.png)|*.png*|All File(*.*)|*.*";
            //(*.txt) | *.txt | All files(*.*) | *.* "'


            if (op.ShowDialog() == DialogResult.OK)
            {
                picbox.Image = new Bitmap(op.FileName);
                txtImagePath.Text = op.FileName;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtImagePath.Clear();
            //picbox.Image=null;
            txtMobileNo.Clear();
            txtName.Clear();
            txtDOB.ResetText();
            txtCNIC.Clear();
            txtFathMobileNo.Clear();
            txtFathName.Clear();
            txtFathMobileNo.Clear();
            txtAddress.Clear();
            txtUniClogName.Clear();
            txtEmailid.Clear();
            txtLiving.SelectedIndex = -1;
            picbox.ImageLocation = @"F:\C# project\mman.jpg";
        }
        int id;
        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Int64 mobileno = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtFathName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Int64 cnic = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            Int64 fmobileno = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            txtDOB.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtUniClogName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtAddress.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtEmailid.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtLiving.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtImagePath.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();

            string image = txtImagePath.Text;
            picbox.ImageLocation = @"" + image + "";
            txtMobileNo.Text = mobileno.ToString();
            txtCNIC.Text = cnic.ToString();
            txtFathMobileNo.Text = fmobileno.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtMobileNo.Text != "" && txtName.Text != "" && txtFathName.Text != "" && txtAddress.Text != "" && txtCNIC.Text != "" && txtFathMobileNo.Text != "" && txtUniClogName.Text != "" )
            {
                if (txtImagePath.Text != "")
                {
                    Int64 mobileno = Int64.Parse(txtMobileNo.Text);
                    string name = txtName.Text;
                    string fname = txtFathName.Text;
                    Int64 cnic = Int64.Parse(txtCNIC.Text);
                    Int64 fmobileno = Int64.Parse(txtFathMobileNo.Text);
                    string dob = txtDOB.Text;
                    string uni = txtUniClogName.Text;
                    string address = txtAddress.Text;
                    string email = txtEmailid.Text;
                    string living = txtLiving.Text;
                    string image = txtImagePath.Text;

                    query= "update AddStudent set MobileNo="+mobileno+",Name='"+name+"',FName='"+fname+"',CNIC="+cnic+ ",FMobileNo="+fmobileno+ ",DOB='"+dob+ "',UniorCollege='"+uni+"',Address='"+address+ "',Email='"+email+"',Living='"+living+"',Image='"+image+"' where ID="+id+"";
                    fn.setData(query, "Data Update Successfully");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Please Add Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please Fill All Boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        int sid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sid = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want to Delete","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                query = "delete from AddStudent where ID=" + sid + "";
                fn.setData(query, "Student Delete Successfully");
                loadData();
            }
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from addStudent where name like'"+txtSearch.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
