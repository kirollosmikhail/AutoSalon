using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterProp : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        lblNome.Text = Session["USR"].ToString();

        if (Session["USR"].ToString() == "info@brovia.it")
        {
            litRicavi.Text = "<a href=\"Ricavi.aspx\">Ricavi</a>";

        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session["USR"] = "";
        Response.Redirect("HomePage.aspx");
    }
}
