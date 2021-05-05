using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Stored_Procedure_Example;

namespace Stored_Procedure_Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("server=.;uid=sa;pwd=abc;database=storedprocEx;");
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        internal void BindEmp()
        {
            cmd = new SqlCommand("Select * from Emp", conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            GridEmp.DataSource = ds.Tables[0];
            GridEmp.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindEmp();
                txtEmpNo.Focus();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("sp_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Eno", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Ename", txtEmpName.Text);
            cmd.Parameters.AddWithValue("@Salary", txtEmpSal.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i>0)
            {
                lblMsg.Text = "Record is Inserted";
            }
            else
            {
                lblMsg.Text = "Record is not Inserted...";
            }
            txtEmpNo.Text = "";
            txtEmpName.Text = "";
            txtEmpSal.Text = "";
            txtDeptNo.Text = "";
            txtEmpNo.Focus();
            BindEmp();
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("sp_Find", conn);
            cmd.Parameters.AddWithValue("@Eno", txtEmpNo.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i<0)
            {
                lblMsg.Text = "Record is Found";
            }
            else
            {
                lblMsg.Text = "Record is not Found...";
            }
            txtEmpNo.Text = "";
            txtEmpName.Text = "";
            txtEmpSal.Text = "";
            txtDeptNo.Text = "";
            txtEmpNo.Focus();
            BindEmp();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("sp_Delete", conn);
            cmd.Parameters.AddWithValue("@Eno", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Ename", txtEmpName.Text);
            cmd.Parameters.AddWithValue("@Salary", txtEmpSal.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i==1)
            {
                lblMsg.Text = "Record is Deleted";
            }
            else
            {
                lblMsg.Text = "Record is not Deleted...";
            }
            txtEmpNo.Text = "";
            txtEmpName.Text = "";
            txtEmpSal.Text = "";
            txtDeptNo.Text = "";
            txtEmpNo.Focus();
            BindEmp();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("sp_Update", conn);
            cmd.Parameters.AddWithValue("@Eno", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Salary", txtEmpSal.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if(i==1)
            {
                lblMsg.Text = "Record is Updated";
            }
            else
            {
                lblMsg.Text = "Record is Not Updated...";
            }
            
            txtEmpNo.Text = "";
            txtEmpName.Text = "";
            txtEmpSal.Text = "";
            txtDeptNo.Text = "";
            txtEmpNo.Focus();
            BindEmp();
        }

       
        
        

        
    }
}