using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebApplication3
{
    public partial class CreateEmployee : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    string query = "select id,name from countries";
                    DataSourceBinding.bindDropdown(ddl_country, query, "id", "name");

                    string emp_query = "select id,firstname from employees";
                    DataSourceBinding.bindRadioButtonList(rdb_lst, emp_query, "id", "firstname");
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = "sd";
                string lastName = txt_lastName.Text;
                string email = txt_email.Text;
                string contactNo = txt_contactNo.Text;
                string salary = txt_salary.Text;
                int countryId = Convert.ToInt32(ddl_country.SelectedValue);
                int gender = rdb_male.Checked ? 1 : 2;

                string query = "INSERT INTO Employees(FirstName,LastName,Email,Gender,ContactNo,Country_Id,Salary,IsActive) " +
                               "Values(" + firstName + "," + lastName + ",@Email,@Gender,@ContactNo,@Country_Id,@Salary,1)";

                SqlConnection sqlConnection = DataBaseOperations.getConnection();

                SqlCommand cmd = new SqlCommand(query, sqlConnection);

                cmd.Parameters.Add(new SqlParameter("@FirstName", firstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", lastName));
                cmd.Parameters.Add(new SqlParameter("@Email", email));
                cmd.Parameters.Add(new SqlParameter("@Gender", gender));
                cmd.Parameters.Add(new SqlParameter("@ContactNo", contactNo));
                cmd.Parameters.Add(new SqlParameter("@Country_Id", countryId));
                cmd.Parameters.Add(new SqlParameter("@Salary", salary));

                //string update_query = "UPDATE Employees SET FirstName = '" + firstName + "'," +
                //                                     "LastName = '" + lastName + "'," +
                //                                     "Email = '" + email + "'," +
                //                                     "ContactNo = '" + contactNo + "'," +
                //                                     "Salary = '" + salary + "'," +
                //                                     "Country_id = '" + countryId + "'," +
                //                                     "Gender = '" + gender + "'," +
                //                                     "WHERE Emp_id=" + 1;


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