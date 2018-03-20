using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


/// <summary>
/// Summary description for Users
/// </summary>
public class Users
{
    public Users()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static int addnewuser(string user_fname, string user_lname)
    {
        DataAccessLayer.Open();
        int i = DataAccessLayer.ExecuteNonQuery("addnewuser", CommandType.StoredProcedure,
            DataAccessLayer.CreateParameter("@user_fname", SqlDbType.NVarChar, user_fname),
            DataAccessLayer.CreateParameter("@user_lname", SqlDbType.NVarChar, user_lname));
        DataAccessLayer.Close();
        return i;
    }
}