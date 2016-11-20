using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class server_Default : System.Web.UI.Page
{
    static string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security = True; Connect Timeout = 30";
    static SqlConnection conn = new SqlConnection(connstr);
    protected void Page_Load(object sender, EventArgs e)
    {

        Response.AppendHeader("Access-Control-Allow-Origin", "*");
        try
        {
            conn.Open();
            Response.Write("połączenie otwarte");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            conn.Close();
            Response.Write("połączenie zamkniete");
        }

        //baza danych
        switch (Request["action"])
        {
            case "create":
                Response.Write("create");
                createTable();
                break;
            /*case "drop":
                Response.Write("drop");
                dropTable();
                break;*/
        }


    }

    private void createTable() {
        Response.AppendHeader("Access-Control-Allow-Origin", "*");
        conn.Open();
        string sql = "CREATE TABLE nazwaTabeli (id INTEGER, poleA VARCHAR(10), poleB VARCHAR(20))";
        SqlCommand command = new SqlCommand();
        command.CommandText = sql;
        command.Connection = conn;
        command.ExecuteNonQuery(); // wykonanie
        conn.Close();
    }
    /*private void dropTable()
    {
        conn.Open();
        string sql = "CREATE TABLE nazwaTabeli (id INTEGER, poleA VARCHAR(10), poleB VARCHAR(20))";
        SqlCommand command = new SqlCommand();
        command.CommandText = sql;
        command.Connection = conn;
        command.ExecuteNonQuery(); // wykonanie
        conn.Close();
    }*/
}