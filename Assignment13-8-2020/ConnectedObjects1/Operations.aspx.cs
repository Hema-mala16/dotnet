using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedObjects1
{
    public partial class Operations : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-71INDHC;Initial Catalog=Assignments;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public void ShowGrid()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from EmpTb1", conn);

            SqlDataReader sdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            sdr.Close();
            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowGrid();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            //=====================storedprocedure where query we have write in SqlSever========================== 
            conn.Open();
            cmd = new SqlCommand("sp_InsertEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName", TtxtName.Text);
            cmd.Parameters.AddWithValue("@EmpSal", txtSal.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();


        }

        protected void btnName_Click(object sender, EventArgs e)
        {
            // ===========single & dounle Quotation============ 
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from EmpTb1   where EmpId='" + txtId.Text + "'", conn);

            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update EmpTb1 set EmpName=@empName, EmpSal=@empsal where EmpId=@empid", conn);
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(txtId.Text);
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = TtxtName.Text;

            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(txtSal.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            ShowGrid();
        }

        protected void btnSpInsert_Click(object sender, EventArgs e)
        {
            //=====================storedprocedure where query we have write in SqlSever========================== 
            conn.Open();
            cmd = new SqlCommand("sp_InsertEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName", TtxtName.Text);
            cmd.Parameters.AddWithValue("@EmpSal", txtSal.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnSpUpdate_Click(object sender, EventArgs e)
        {

            conn.Open();
            cmd = new SqlCommand("sp_UpdateEmpl", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EmpId", SqlDbType.Int).Value = Convert.ToInt32(txtId.Text);
            cmd.Parameters.Add("@EmpName", SqlDbType.VarChar, 20).Value = TtxtName.Text;
            cmd.Parameters.Add("@EmpSal", SqlDbType.Int).Value = Convert.ToInt32(txtSal.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            //----------------parameters @--------------
            conn.Open();
            cmd = new SqlCommand("delete from EmpTb1  where empId=@EmpId", conn);
            cmd.Parameters.Add("@empId", SqlDbType.Int).Value = Convert.ToInt32(txtId.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}