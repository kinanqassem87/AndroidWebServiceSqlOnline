using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


/// <summary>
/// Summary description for DataAccessLayer
/// </summary>
public class DataAccessLayer
{
    public DataAccessLayer()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    //Server=Admin (Name of Computer) ; /Or Server=192.168.1.99;
    //public static string con = "Server= Admin; Database= CV_Archive; Integrated Security=True;";
    public static string con = "Server= den1.mssql3.gear.host; Database= testweb;User ID=testweb ;Password=Ow6h_5y8OT_p;Pooling=false;";



    public static SqlConnection cn;
    //open the connection 
    public static void Open()
    {
        cn = new SqlConnection(con);
        cn.Open();

    }
    //close the connection 
    public static void Close()
    {

        cn = new SqlConnection(con);
        cn.Close();

    }
    //return one value
    public static object ExcuteScalar(string query, CommandType type, params SqlParameter[] arr)
    {
        SqlCommand cmd = new SqlCommand(query, cn);
        cmd.Parameters.AddRange(arr);
        cmd.CommandType = type;
        object o = cmd.ExecuteScalar();
        return o;

    }
    //delete,Update,insert return number of effect rows
    public static int ExecuteNonQuery(string query, CommandType type, params SqlParameter[] arr)
    {
        SqlCommand cmd = new SqlCommand(query, cn);
        cmd.CommandType = type;
        cmd.Parameters.AddRange(arr);
        int n = cmd.ExecuteNonQuery();
        return n;

    }
    //return table
    public static DataTable ExecuteTable(string query, CommandType type, params SqlParameter[] arr)
    {
        SqlCommand cmd = new SqlCommand(query, cn);
        cmd.CommandType = type;
        cmd.Parameters.AddRange(arr);
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }
    //create parameter to use above function return parameter
    public static SqlParameter CreateParameter(string name, SqlDbType type, object value)
    {
        SqlParameter pr = new SqlParameter();
        pr.ParameterName = name;
        pr.SqlDbType = type;
        pr.SqlValue = value;
        return pr;
    }
}