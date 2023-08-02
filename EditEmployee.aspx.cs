using System;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class EditEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int.TryParse(Request.QueryString["emp_id"], out int employeeId);

            if (!Page.IsPostBack)
            {
                string query = "select id,name from countries";
                DataSourceBinding.bindDropdown(ddl_country, query, "id", "name");


                string emp_query = "select * from employees where id = " + employeeId;

                DataTable dt = DataBaseOperations.getDataTableValues(emp_query);

                BindValues(dt.Rows[0].ItemArray);
            }

            // int a = Convert.ToInt32(Request.QueryString["emp_id"]);

            if (employeeId == 0)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void BindValues(object[] itemArray)
        {
            txt_firstName.Text = itemArray[1].ToString();
            txt_lastName.Text = itemArray[2].ToString();
            txt_email.Text = itemArray[3].ToString();
            if (itemArray[4] != null)
            {
                rdb_male.Checked = Convert.ToInt32(itemArray[4]) == 1 ? true : false;
                rdb_female.Checked = Convert.ToInt32(itemArray[4]) == 2 ? true : false;
            }

            if (itemArray[6] != null)
            {
                ddl_country.Items.FindByValue(itemArray[6].ToString()).Selected = true;
            }
            txt_contactNo.Text = itemArray[5].ToString();
            txt_salary.Text = itemArray[7].ToString();
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txt_firstName.Text;
                string lastName = txt_lastName.Text;
                string email = txt_email.Text;
                string contactNo = txt_contactNo.Text;
                string salary = txt_salary.Text;
                int countryId = Convert.ToInt32(ddl_country.SelectedValue);
                int gender = rdb_male.Checked ? 1 : 2;

                string query = "UPDATE Employees(FirstName,LastName,Email,Gender,ContactNo,Country_Id,Salary,IsActive) " +
                               "Values(" + firstName + "," + lastName + ",@Email,@Gender,@ContactNo,@Country_Id,@Salary,1)";

                SqlConnection sqlConnection = DataBaseOperations.getConnection();

                SqlCommand cmd = new SqlCommand(query, sqlConnection);

                cmd.ExecuteNonQuery();

                sqlConnection.Close();

                Response.Redirect("Employees.aspx");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}