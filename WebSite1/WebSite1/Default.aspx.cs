using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (!txtfname.Text.Equals("") && !txtlname.Text.Equals(""))
        {
            Users.addnewuser(txtfname.Text, txtlname.Text);
            btnAdd.Text = "Saved";
            txtfname.Text = txtlname.Text = "";
        }
    }
}