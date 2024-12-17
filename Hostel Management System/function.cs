using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    internal class function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source= DESKTOP-7IUUBVC\\SQLEXPRESS;Initial Catalog=HostelDB;Integrated Security=True";
            return con;
        }
        public DataSet getData(string query)
        { 
            SqlConnection con= GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter sda= new SqlDataAdapter(cmd);
            DataSet ds= new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public void setData(string query, string msg)
        {
            SqlConnection con= GetConnection();
            SqlCommand cmd= new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
