using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.AllUserControls
{
    public partial class UC_AddStudent : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddStudent()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
           OpenFileDialog op= new OpenFileDialog();
            op.Filter = "JPG (*.jpg)|*.jpg*|JPEG (*.jpeg)|*.jpeg*|PNG (*.png)|*.png*|All File(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picbox.Image=new Bitmap(op.FileName);
                txtImagePath.Text=op.FileName;
            }
        }
        int rid;
        private void UC_AddStudent_Load(object sender, EventArgs e)
        {
            txtImagePath.Visible = false;

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            allClear();
        }

        public void allClear()
        {
            txtImagePath.Clear();
            //picbox.Image=null;
            txtMobileNo.Clear();
            txtName.Clear();
            txtRoomNo.SelectedIndex = -1;
            txtRoomType.SelectedIndex = -1;
            txtDOB.ResetText();
            txtCNIC.Clear();
            txtFathMobileNo.Clear();
            txtFathName.Clear();
            txtFathMobileNo.Clear();
            txtAddress.Clear();
            txtUniClogName.Clear();
            picbox.ImageLocation = @"F:\C# project\mman.jpg";
        }
     
        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            txtRoomNo.Items.Clear();
            query = "select RoomNo  from room where RoomType='" + txtRoomType.Text + "' and RoomCompacity='No-Full'  and RoomStatus='Yes'";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 roomno = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                txtRoomNo.Items.Add(roomno);

                txtRoomNo.SelectedIndex = 0;
            }
           

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if(txtMobileNo.Text !="" && txtName.Text !="" && txtRoomNo.Text !="" && txtFathName.Text !="" && txtAddress.Text !="" && txtCNIC.Text !="" && txtFathMobileNo.Text !="" && txtRoomType.Text !="" && txtUniClogName.Text !="")
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
                    string image = txtImagePath.Text;


                    query = "insert into AddStudent(MobileNo,Name,FName,CNIC,FMobileNo,DOB,UniorCollege,Address,Email,Image,RoomID) values(" + mobileno + ",'" + name + "','" + fname + "'," + cnic + "," + fmobileno + ",'" + dob + "','" + uni + "','" + address + "','" + email + "','" + image + "',"+rid+") update room set Booked='YES' where RoomNo =" + txtRoomNo.Text + "";
                    fn.setData(query, "Student Add Successfully");
                    allClear();
                }
                else
                {
                    MessageBox.Show("Please Add Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please Fill All Boxes","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select RoomID from room where RoomNo ='" + txtRoomNo.Text + "'";
           DataSet ds = fn.getData(query);
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                rid = int.Parse(ds.Tables[0].Rows[i][0].ToString());
            }
           
        }
        //Int64 count;
        //public void setbooking()
        //{
        //    query = "select count(RoomNo) from AddStudent where roomno='"+txtRoomNo.Text+"' ";
        //   DataSet ds = fn.getData(query);

        //    count =Int64.Parse (ds.Tables[0].Rows[0][0].ToString());
        //    if(count<=2)
        //    {
        //        txtRoomNo.Items.Clear();
        //        query = "select RoomNo  from room where RoomType='" + txtRoomType.Text + "' and RoomCompacity='No-Full'  and RoomStatus='Yes'";
        //       ds = fn.getData(query);

        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            Int64 roomno = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
        //            txtRoomNo.Items.Add(roomno);

        //            //txtRoomNo.SelectedIndex = 0;
        //        }
        //    }
        //    else
        //    {
        //        query = "update room set RoomCompacity='Full' where roomno='"+txtRoomNo.Text+"'";
        //        fn.setData(query, "Room Campacity is Full");
        //    }
        //}
    }
}
