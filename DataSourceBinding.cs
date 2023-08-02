using System.Data;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public static class DataSourceBinding
    {
        public static void bindGrid(GridView grid, string query)
        {
            DataTable dt;

            dt = DataBaseOperations.getDataTableValues(query, false);

            grid.DataSource = dt;
            grid.DataBind();
        }

        public static void bindGrid(GridView grid, string query, bool isProc)
        {
            DataTable dt;

            dt = DataBaseOperations.getDataTableValues(query, isProc);

            grid.DataSource = dt;
            grid.DataBind();
        }

        public static void bindDropdown(DropDownList ddl, string query, string valueField, string textField)
        {
            DataTable dt = DataBaseOperations.getDataTableValues(query);

            ddl.DataSource = dt;
            ddl.DataValueField = valueField;
            ddl.DataTextField = textField;
            ddl.DataBind();
        }

        public static void bindRadioButtonList(RadioButtonList rdb_list, string query, string valueField, string textField)
        {
            DataTable dt = DataBaseOperations.getDataTableValues(query);

            rdb_list.DataSource = dt;
            rdb_list.DataValueField = valueField;
            rdb_list.DataTextField = textField;
            rdb_list.DataBind();
        }
    }
}