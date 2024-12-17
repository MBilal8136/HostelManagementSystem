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
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        string query;

        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
           labelchek.Visible= false;
            CheckYes.Checked = true;

            filldata();
        }
        string status;

        private void brnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtRoomtype.Text != "")
            {
                query = "select * from room where RoomNo ='" + txtRoomNo.Text + "'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    if (CheckYes.Checked)
                    {
                        status = "Yes";
                    }
                    else
                    {
                        status = "No";
                    }
                    ifcodi();
                    booke();
                    labelchek.Visible = false;
                    //picbox.ImageLocation = @"F:\C# project\Pharmacy Management System in C#\yes.png";
                    string roomno = txtRoomNo.Text;
                    string roomtype = txtRoomtype.Text;
                    string syes = status;
                    string comp = compacity;

                    query = "insert into room( RoomNo,RoomType,RoomCompacity,RoomStatus) values('" + roomno + "','" + roomtype + "','" + comp + "','" + syes + "')";
                    fn.setData(query, "Room Add Successfullly");
                    filldata();
                    allClear();
                }
                else
                {
                    labelchek.Text = "This Room No Already Exist";
                    labelchek.Visible = true;
                    //picbox.ImageLocation = @"F:\C# project\Pharmacy Management System in C#\no.png";
                }
            }
            else
            {
                MessageBox.Show("Please fill Boxs", "Conformation", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }
        string compacity;
        protected void ifcodi()
        {
            if(CheckBoxYes.Checked)
            {
                compacity = "Full";
            }
            else
            {
                compacity = "No-Full";
            }
        }
        string book;
        protected void booke()
        {
            if (checkbooked.Checked)
            {
                book = "YES";
            }
            else
            {
               book = "NO";
            }
        }

        public void filldata()
        {
            query = "select * from room ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        public void allClear()
        {
            txtRoomNo.Clear();
            txtRoomtype.SelectedIndex = -1;
            CheckBoxYes.Checked = false;
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoomNo.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRoomtype.Text= guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string capyes = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string statyes = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string booki = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            if (capyes == "No-Full")
            {
                CheckBoxYes.Checked= false;
            }
            else if(capyes == "Full")
            {
                CheckBoxYes.Checked= true;
            }
            else if (statyes == "Yes")
            {
                CheckYes.Checked = true;
            }
            else if (statyes == "No")
            {
                CheckYes.Checked = false;
            }
            else if (booki == "NO")
            {
                checkbooked.Checked = false;
            }
            else if (booki == "YES")
            {
                checkbooked.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtRoomtype.Text != "")
            {

                if (CheckYes.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                ifcodi();
                booke();
                labelchek.Visible = false;

                string roomno = txtRoomNo.Text;
                string roomtype = txtRoomtype.Text;
                string syes = status;
                string comp = compacity;
                string booking = book;

                query = "update room set RoomNo='" + roomno + "',RoomType='" + roomtype + "',RoomCompacity='" + comp + "',RoomStatus='" + syes + "',Booked='"+booking+"' where Roomid=" + id + "";
                fn.setData(query, "Room Update Successfully");
                filldata();
                allClear();
            }
            else
            {
                MessageBox.Show("Please fill Boxs", "Conformation", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id= int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Delete?","Conformation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                query = "delete from room where RoomID=" + id + "";
                fn.setData(query, "Room Delete Successfully");
                filldata();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from room where RoomNo ='" + txtSearch.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("This "+ txtSearch.Text + " Exist","Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Clear();

            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            allClear();
            filldata();
            txtSearch.Clear();

        }
    }
}
