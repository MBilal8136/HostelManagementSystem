using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hostel_Management_System.AllUserControls
{
    public partial class UC_Checkout : UserControl
    {
        function fn = new function();
        string query;
        public UC_Checkout()
        {
            InitializeComponent();
        }

        private void UC_Checkout_Load(object sender, EventArgs e)
        {
            fillData();
        }

        public void fillData()
        {
            query = "select AddStudent.ID,AddStudent.MobileNo,AddStudent.Name,AddStudent.FName,AddStudent.CNIC,AddStudent.FMobileNo,AddStudent.DOB,AddStudent.UniorCollege,AddStudent.Address,AddStudent.Email,AddStudent.Living,room.RoomNo,room.RoomType,room.RoomCompacity,room.RoomStatus,room.Booked from AddStudent inner join room on AddStudent.RoomID = room.RoomID where Living='Yes' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //    txtName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    txtcheckout.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            //    txtcheckout.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();

            //}
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
               txtRoomNo.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtcheckout.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtRoomNo.Text != "")

            {
                if (txtcheckout.Text == "Yes")
                {
                    if (MessageBox.Show("Are You sure for Check Out ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                            // string cdate = txtCheckOut.Text;
                            query = "update AddStudent set Living ='No' where ID =" + id + "";
                        //" update rooms set Booked='No' where RoomNo='" + txtRoomNo.Text + "'";
                        fn.setData(query, "Check Out Successfull.");
                        fillData();

                    }
                    else
                    {
                        txtName.Clear();
                        txtRoomNo.Clear();
                        txtcheckout.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Checkout is not Equal to 'YES'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("No Student Selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select AddStudent.ID,AddStudent.MobileNo,AddStudent.Name,AddStudent.FName,AddStudent.CNIC,AddStudent.FMobileNo,AddStudent.DOB,AddStudent.UniorCollege,AddStudent.Address,AddStudent.Email,AddStudent.Living,room.RoomNo,room.RoomType,room.RoomCompacity,room.RoomStatus,room.Booked from AddStudent inner join room on AddStudent.RoomID = room.RoomID where Name like '"+txtSearch.Text+"%' and Living='Yes' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            fillData();
            txtSearch.Clear();
            txtName.Clear();
            txtRoomNo.Clear();
            txtcheckout.Clear();
        }
    }
}
