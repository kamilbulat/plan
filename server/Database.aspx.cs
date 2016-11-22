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

/**
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
    */

        //baza danych
        switch (Request["action"])
        {
            case "create":
                Response.Write("dodawanie tabeli zakonczone ");
                createTable();
                break;

            case "drop":
                Response.Write("usuwanie tabeli zakonczone ");
                dropTable();
                break;

            case "insert":
                Response.Write("dodawanie danych do tabeli  zakonczone ");
                insertData();
                break;
            case "delete":
                Response.Write("usuwanie danych z tabeli zakonczone ");
                deleteData();
                break;
        }


    }

    //tworzenie tabeli
    private void createTable()
    {
        //Response.AppendHeader("Access-Control-Allow-Origin", "*");
        try
        {
            conn.Open();
            string sql = "CREATE TABLE nazwaTabeli (id INTEGER IDENTITY(1,1), poleA VARCHAR(10), poleB VARCHAR(20))";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = conn;
            command.ExecuteNonQuery(); // wykonanie
            Response.Write("powodzeniem");
        }
        catch (Exception ex)
        {
            Response.Write("niepowodzeniem: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    //usuwanie tabeli
    private void dropTable()
    {
        // Response.AppendHeader("Access-Control-Allow-Origin", "*");
        try
        {
            conn.Open();
            string sql = "DROP TABLE nazwaTabeli";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = conn;
            command.ExecuteNonQuery(); // wykonanie
            Response.Write("powodzeniem");
        }
        catch (Exception ex)
        {
            Response.Write("niepowodzeniem: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }

    }

    //dodawanie danych
    private void insertData()
    {
        // Response.AppendHeader("Access-Control-Allow-Origin", "*");
        try
        {
            conn.Open();
            string sql = "INSERT INTO nazwaTabeli (poleA, poleB) VALUES('a','b')";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = conn;
            command.ExecuteNonQuery(); // wykonanie
            Response.Write("powodzeniem");
        }
        catch (Exception ex)
        {
            Response.Write("niepowodzeniem: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }

    }

    //usuwanie danych
    private void deleteData()
    {
        try
        {
            conn.Open();
            string sql = "DELETE FROM nazwaTabeli";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = conn;
            command.ExecuteNonQuery(); // wykonanie
            Response.Write("powodzeniem");
        }
        catch (Exception ex)
        {
            Response.Write("niepowodzeniem: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }

    }
}
