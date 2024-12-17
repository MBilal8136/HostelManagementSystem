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
    public partial class UC_StudentFees : UserControl
    {
        function fn = new function();
        string query;
        public UC_StudentFees()
        {
            InitializeComponent();
        }

        private void UC_StudentFees_Load(object sender, EventArgs e)
        {
            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.CustomFormat = "MMMM yyyy";
            txtimagePath.Visible = false;
            //setDataGrid();
        }
        public void setDataGrid(Int64 id)
        {
            query = "select * from fee where ID="+id+" ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtDuesAmount.Text != "" && txtRemDues.Text != "")
            {
                Int64 id = Int64.Parse(txtID.Text);
                query = " select * from fee where ID=" + id + " and Date='" + txtDate.Text + "'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 fid = Int64.Parse(txtID.Text);
                    string name = txtName.Text;
                    string fname = txtFName.Text;
                    string date = txtDate.Text;
                    Int64 roomno = Int64.Parse(txtRoomNo.Text);
                    Int64 amount = Int64.Parse(txtDuesAmount.Text);
                    Int64 remain = Int64.Parse(txtRemDues.Text);

                    query = "insert into fee(ID,Name,FName,Date,RoomNo,Amount,Remaining) values(" + fid + ",'" + name + "','" + fname + "','" + date + "'," + roomno + "," + amount + "," + remain + ")";
                    fn.setData(query, "Fee Pay Succssfully");
                    setDataGrid(Int64.Parse(txtID.Text));
                    clear();

                }
                else
                {
                    MessageBox.Show("This Month's Fee Allready Paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please Enter Remaining Dues.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDuesAmount.Text != "" && txtRemDues.Text != "")
            {
                Int64 amount = Int64.Parse(txtDuesAmount.Text);
                Int64 remain = Int64.Parse(txtRemDues.Text);
                query = "update fee set Amount=" + amount + ",Remaining=" + remain + " where FID='" + fid + "'";
                fn.setData(query, "Dues Update Successfully");
                setDataGrid(Int64.Parse(txtID.Text));
                clear();
            }
            else
            {
                txtRemDues.Text = "0";
            }
        }
        int fid;
        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fid = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDate.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Int64 amount = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            Int64 remain = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            txtDuesAmount.Text = amount.ToString();
            txtRemDues.Text = remain.ToString();
        }
        public void AllClear()
        {
            txtID.Clear();
            txtFName.Clear();
            txtDate.ResetText();
            txtRemDues.Clear();
            txtRoomNo.Clear();
            txtName.Clear();
            txtDuesAmount.Clear();
            txtimagePath.Clear();
            picbox.ImageLocation = @"F:\\C# project\\mman.jpg";
            guna2DataGridView1.DataSource = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           AllClear();
        }
        string file;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {

                query = " select Name, FName,image from AddStudent where ID=" + txtID.Text + "";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtFName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtimagePath.Text = ds.Tables[0].Rows[0][2].ToString();


                    {
                        query = "select room.RoomNo  from room inner join AddStudent on room.RoomID= AddStudent.RoomID where ID=" + txtID.Text + " ";
                        ds = fn.getData(query);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            txtRoomNo.Text = ds.Tables[0].Rows[i][0].ToString();
                        }
                        setDataGrid(Int64.Parse(txtID.Text));
                      
                        if (txtimagePath.Text != "")
                        {
                            file = @"" + txtimagePath.Text + "";
                            picbox.ImageLocation = file;
                        }
                        else
                        {
                            picbox.ImageLocation = @"F:\\C# project\\mman.jpg";
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Recode not Exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AllClear();
                }
            }
            else
            {
                MessageBox.Show("No ID Enter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AllClear();
            }
        }
        public void clear()
        {

            //txtID.Clear();
            txtFName.Clear();
            txtDate.ResetText();
            txtRemDues.Clear();
            txtRoomNo.Clear();
            txtName.Clear();
            txtDuesAmount.Clear();
            txtimagePath.Clear();
            picbox.ImageLocation = @"F:\\C# project\\mman.jpg";
        }
    }
}
