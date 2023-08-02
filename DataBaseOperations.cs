using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public static class DataBaseOperations
    {

        public static SqlConnection getConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["demo-connection"].ConnectionString.ToString();
            string testConnectionString = ConfigurationManager.ConnectionStrings["test-connection"].ConnectionString.ToString();

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            return sqlConnection;
        }

        //
        public static DataTable getDataTableValues(string query, bool? isProc = false)
        {
            SqlConnection sqlConnection = getConnection();

            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isProc == true)
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand.Parameters.Add(new SqlParameter("@Emp_Id", 0));
            }

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }


        ////
        //public static DataTable getDataTableValuesWithProcedure(string procedure)
        //{
        //    SqlConnection sqlConnection = getConnection();

        //    SqlCommand command = new SqlCommand(procedure, sqlConnection);

        //    SqlDataAdapter adt = new SqlDataAdapter(command);


        //    DataTable dt = new DataTable();
        //    adt.Fill(dt);

        //    return dt;
        //}
    }
}