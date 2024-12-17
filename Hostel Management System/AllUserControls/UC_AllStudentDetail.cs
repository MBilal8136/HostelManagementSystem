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

namespace Hostel_Management_System.AllUserControls
{
    public partial class UC_AllStudentDetail : UserControl
    {
        function fn = new function();
        string query;
        public UC_AllStudentDetail()
        {
            InitializeComponent();
        }



        private void txtcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtcombo.SelectedIndex == 0)
            {
                query = "select AddStudent.ID,AddStudent.MobileNo,AddStudent.Name,AddStudent.FName,AddStudent.CNIC,AddStudent.FMobileNo,AddStudent.DOB,AddStudent.UniorCollege,AddStudent.Address,AddStudent.Email,AddStudent.Living,room.RoomNo,room.RoomType,room.RoomCompacity,room.RoomStatus,room.Booked from AddStudent inner join room on AddStudent.RoomID = room.RoomID ";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtcombo.SelectedIndex == 1)
            {
                query = "select AddStudent.ID,AddStudent.MobileNo,AddStudent.Name,AddStudent.FName,AddStudent.CNIC,AddStudent.FMobileNo,AddStudent.DOB,AddStudent.UniorCollege,AddStudent.Address,AddStudent.Email,AddStudent.Living,room.RoomNo,room.RoomType,room.RoomCompacity,room.RoomStatus,room.Booked from AddStudent inner join room on AddStudent.RoomID = room.RoomID where Living='Yes' ";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtcombo.SelectedIndex == 2)
            {
                query = "select AddStudent.ID,AddStudent.MobileNo,AddStudent.Name,AddStudent.FName,AddStudent.CNIC,AddStudent.FMobileNo,AddStudent.DOB,AddStudent.UniorCollege,AddStudent.Address,AddStudent.Email,AddStudent.Living,room.RoomNo,room.RoomType,room.RoomCompacity,room.RoomStatus from AddStudent inner join room on AddStudent.RoomID = room.RoomID where Living='No' ";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void UC_AllStudentDetail_Load(object sender, EventArgs e)
        {
            txtcombo.SelectedIndex = 0;
            query = "select AddStudent.ID,AddStudent.MobileNo,AddStudent.Name,AddStudent.FName,AddStudent.CNIC,AddStudent.FMobileNo,AddStudent.DOB,AddStudent.UniorCollege,AddStudent.Address,AddStudent.Email,AddStudent.Living,room.RoomNo,room.RoomType,room.RoomCompacity,room.RoomStatus,room.Booked from AddStudent inner join room on AddStudent.RoomID = room.RoomID ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            query = "select * from fee";
            ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];

            leaved();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                query = "select * from fee where ID=" + txtID.Text + " ";
                DataSet ds = fn.getData(query);
                 guna2DataGridView2.DataSource = ds.Tables[0];
              }
            else
            {
                MessageBox.Show("Please First Enter ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }




            //public void setDataGrid(Int64 id)
            //{
            //    query = "select * from fee where ID=" + id + " ";
            //    DataSet ds = fn.getData(query);
            //    guna2DataGridView1.DataSource = ds.Tables[0];
            //}
        }
        public void leaved()
        {
            query = "select AddStudent.ID,AddStudent.MobileNo,AddStudent.Name,AddStudent.FName,AddStudent.CNIC,AddStudent.FMobileNo,AddStudent.DOB,AddStudent.UniorCollege,AddStudent.Address,AddStudent.Email,AddStudent.Living,room.RoomNo,room.RoomType,room.RoomStatus from AddStudent inner join room on AddStudent.RoomID = room.RoomID where living ='No' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView3.DataSource = ds.Tables[0];
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            

            //query = "select * from fee where name like '"+ txtID.Text +"%' ";
            //   DataSet ds = fn.getData(query);
            //  guna2DataGridView2.DataSource = ds.Tables[0];
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            query = "select * from fee  ";
               DataSet ds = fn.getData(query);
              guna2DataGridView2.DataSource = ds.Tables[0];
            txtID.Clear();
        }

        private void txtserachname_TextChanged(object sender, EventArgs e)
        {
            txtcombo.SelectedIndex = 0;
            query = "select AddStudent.ID,AddStudent.MobileNo,AddStudent.Name,AddStudent.FName,AddStudent.CNIC,AddStudent.FMobileNo,AddStudent.DOB,AddStudent.UniorCollege,AddStudent.Address,AddStudent.Email,AddStudent.Living,room.RoomNo,room.RoomType,room.RoomCompacity,room.RoomStatus,room.Booked from AddStudent inner join room on AddStudent.RoomID = room.RoomID where Name like '" + txtserachname.Text+"%' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtnamesearch_TextChanged(object sender, EventArgs e)
        {
            query = "select AddStudent.ID,AddStudent.MobileNo,AddStudent.Name,AddStudent.FName,AddStudent.CNIC,AddStudent.FMobileNo,AddStudent.DOB,AddStudent.UniorCollege,AddStudent.Address,AddStudent.Email,AddStudent.Living,room.RoomNo,room.RoomType,room.RoomStatus from AddStudent inner join room on AddStudent.RoomID = room.RoomID where Name like '"+txtnamesearch.Text+"%' and living ='No' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView3.DataSource = ds.Tables[0];
        }
    }
}
