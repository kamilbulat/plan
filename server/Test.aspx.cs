using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class server_Default : System.Web.UI.Page
{
    static string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security = True; Connect Timeout = 30";
    static SqlConnection conn = new SqlConnection(connstr);
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.AppendHeader("Access-Control-Allow-Origin", "*");

    }
    private void downloadData()
    {
        try
        {
            conn.Open();
            string sql = "SELECT * FROM godziny";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Response.Write("OK!");

        }
        catch (Exception ex)
        {
            Response.Write("whats going wrong: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
}