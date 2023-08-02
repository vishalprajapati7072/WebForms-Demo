using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class ContactUs : System.Web.UI.Page
    {
        //const string con_string = "Data Source=PCLPT152\\SQL2019;Initial Catalog=Demo;User id=sa;Password=Tatva@123;";
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!Page.IsPostBack)
        //        {
        //            string query = "select id,name from countries";
        //            this.bindDropdown(ddl_country, query, "id", "name");


        //            string emp_query = "select id,firstname,email from employees";
        //            //this.bindDropdown(ddl_emp, emp_query, "id", "firstname");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //protected void btn_submit_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string firstName = txt_firstName.Text;
        //        string lastName = txt_lastName.Text;
        //        string email = txt_email.Text;
        //        string contactNo = txt_contactNo.Text;
        //        string salary = txt_salary.Text;
        //        int countryId = Convert.ToInt32(ddl_country.SelectedValue);
        //        int gender = rdb_male.Checked ? 1 : 2;

        //        string query = "INSERT INTO Employees(FirstName,LastName,Email,Gender,ContactNo,Country_Id,Salary,IsActive) " +
        //                       "Values(@FirstName,@LastName,@Email,@Gender,@ContactNo,@Country_Id,@Salary,1)";

        //        SqlConnection sqlConnection = this.getConnection();

        //        SqlCommand cmd = new SqlCommand(query, sqlConnection);

        //        cmd.Parameters.Add(new SqlParameter("@FirstName", firstName));
        //        cmd.Parameters.Add(new SqlParameter("@LastName", lastName));
        //        cmd.Parameters.Add(new SqlParameter("@Email", email));
        //        cmd.Parameters.Add(new SqlParameter("@Gender", gender));
        //        cmd.Parameters.Add(new SqlParameter("@ContactNo", contactNo));
        //        cmd.Parameters.Add(new SqlParameter("@Country_Id", countryId));
        //        cmd.Parameters.Add(new SqlParameter("@Salary", salary));

        //        cmd.ExecuteNonQuery();

        //        sqlConnection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //private SqlConnection getConnection()
        //{
        //    SqlConnection sqlConnection = new SqlConnection(con_string);
        //    sqlConnection.Open();

        //    return sqlConnection;
        //}

        ////
        //private DataTable getDataTableValues(string query)
        //{
        //    SqlConnection sqlConnection = getConnection();

        //    SqlCommand command = new SqlCommand(query, sqlConnection);
        //    DataTable dt = new DataTable();

        //    SqlDataAdapter adapter = new SqlDataAdapter(command);

        //    adapter.Fill(dt);

        //    //sqlConnection.Close();

        //    return dt;
        //}


        //private void bindDropdown(DropDownList ddl, string query, string valueField, string textField)
        //{
        //    DataTable dt = this.getDataTableValues(query);

        //    ddl.DataSource = dt;
        //    ddl.DataValueField = valueField;
        //    ddl.DataTextField = textField;
        //    ddl.DataBind();
        //}
    }
}