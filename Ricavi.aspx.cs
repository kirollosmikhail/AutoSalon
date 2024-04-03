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

        if (string.IsNullOrEmpty(Session["USR"] as string))
        {
            Response.Redirect("login.aspx");
        }
        if (Session["USR"].ToString() != "info@brovia.it")
        {
            Response.Redirect("");
        }
        if (!IsPostBack)
        {
            RiempiDdl();
            Reset();

        }
    }
    protected void Reset()
    {
        AUTOMOBILI a = new AUTOMOBILI();
        gridRicavi.DataSource = a.Ricavi();
        gridRicavi.DataBind();
        
    }
    protected void RiempiDdl()
    {
        AUTOSALONI ats = new AUTOSALONI();
        ddlAutoSaloni.DataSource = ats.GridAllAutoSaloni();
        ddlAutoSaloni.DataValueField = "Cod_Autosalone";
        ddlAutoSaloni.DataTextField = "Citta";
        ddlAutoSaloni.DataBind();
        ddlAutoSaloni.Items.Insert(0, new ListItem("Select Citta", "NA"));
        ddlAutoSaloni.SelectedIndex = 0;

    }

    protected void ddlAutoSaloni_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlAutoSaloni.SelectedIndex != 0)
        {

            AUTOMOBILI a = new AUTOMOBILI();
            a.Cod_Autosalone =int.Parse( ddlAutoSaloni.SelectedValue);
            gridRicavi.DataSource = a.Ricavi();
            gridRicavi.DataBind();
        }


    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Reset();
        ddlAutoSaloni.SelectedIndex = 0;
    }
}