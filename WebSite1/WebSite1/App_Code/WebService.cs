using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    [WebMethod(MessageName = "Register", Description = "Register new account")]

    [System.Xml.Serialization.XmlInclude(typeof(ReturnData))]
    public ReturnData Register(string Fname, string Lname)  /// get list of notes
    {

        int IsAdded = 1;
        string Message = "";

        // check if we have this account already
       //check by procedure in sql by name or email as you see

        //  saving into db
        try
        {
            Users.addnewuser(Fname, Lname);
            Message = "your account is created succefully";
        }
        catch (Exception ex)
        {
            IsAdded = 0;
            Message = ex.Message;// "Cannot add your inforamtion";
        }

        
        ReturnData rt = new ReturnData();
        rt.Message = Message;
        rt.UserID = IsAdded;

        return rt;

    }
        public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    //[WebMethod]
    //public string HelloWorld()
    //{
        
    //    return "Hello World";
    //}

}
