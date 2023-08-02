using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void lnk_edit_Click(object sender, CommandEventArgs e)
        {
            Response.Redirect("EditEmployee.aspx?emp_id=" + e.CommandArgument);
        }

        protected void lnk_delete_Command(object sender, CommandEventArgs e)
        {
            int.TryParse(e.CommandArgument.ToString(), out int emp_id);

            string query = "Delete Employees where id =" + emp_id;

            SqlConnection sqlConnection = DataBaseOperations.getConnection();

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            cmd.ExecuteNonQuery();

            sqlConnection.Close();

            BindGrid();
        }

        protected void BindGrid()
        {
            string gridQuery = "Select * from Employees";
            string procName = "getEmployees";

            //   DataSourceBinding.bindGrid(grid_emp, gridQuery);

            DataSourceBinding.bindGrid(grid_emp, procName, true);
        }
    }
}