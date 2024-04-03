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

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // controllo usr pwd
        if (txtLoginUSR.Text == "" || txtLoginPWD.Text == "")
        {
            Response.Write("Riempi i campi");
            return;
        }
        UTENTI u = new UTENTI();
        u.USR = txtLoginUSR.Text.Trim();
        u.PWD = txtLoginPWD.Text;
        // controllo se usr pwd e giusti
        if (u.Login())
        {
            Session["USR"] = txtLoginUSR.Text;
            Response.Redirect("RicercaAuto.aspx");
        }
        else
        {
            Response.Write("UTENTE E PASSWORD NON CORRETTI");
        }



    }

    protected void btnRegistrati_Click(object sender, EventArgs e)
    {

    }

    protected void btnRecuperare_Click(object sender, EventArgs e)
    {



    }
}