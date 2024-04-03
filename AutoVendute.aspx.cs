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
        // controllo  session dove se che valori entri se no torna login
        if (string.IsNullOrEmpty(Session["USR"] as string))
        {
            //Response.Redirect("login.aspx");
        }
        if (!IsPostBack)
        {

            CaricaMarche();
            Reset();
            ddlMARCHE.Items.Insert(0, new ListItem("Select Marca", "NA"));
            ddlMARCHE.SelectedIndex = 0;

        }


    }

    protected void ddlMARCHE_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlMARCHE.SelectedIndex == 0)
        {
            return;
        }
        CaricaModelli();
        ddlMODELLI.Items.Insert(0, new ListItem("Select Modello", "NA"));
    }
    // riempe la dropdownlist di marche 
    protected void CaricaMarche()
    {

        MARCHE m = new MARCHE();
        ddlMARCHE.DataSource = m.ddlMarche();
        ddlMARCHE.DataTextField = "Marca";
        ddlMARCHE.DataValueField = "Cod_Marca";
        ddlMARCHE.DataBind();
    }
    // riempe la dropdownlist di Modelli 
    protected void CaricaModelli()
    {

        MODELLI mo = new MODELLI();
        mo.Cod_Marca = int.Parse(ddlMARCHE.SelectedValue);
        ddlMODELLI.DataSource = mo.ddlModelli();
        ddlMODELLI.DataTextField = "mg";
        ddlMODELLI.DataValueField = "Cod_Modello";
        ddlMODELLI.DataBind();

    }
   
    // riporta i dati alla griglia
    protected void Reset()
    {
        AUTOMOBILI a = new AUTOMOBILI();
        gridAuto.DataSource = a.GridAllVendute();

        gridAuto.DataBind();
        ddlMARCHE.SelectedIndex = 0;
        if (ddlMODELLI.SelectedIndex < 0) return;
        ddlMODELLI.SelectedIndex = 0;


    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Reset();
    }

    protected void ddlMODELLI_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlMODELLI.SelectedIndex == 0)
        {
            return;
        }
        if (ddlMODELLI.SelectedValue != "")
        {
            AUTOMOBILI a = new AUTOMOBILI();
            a.Cod_Modello = int.Parse(ddlMODELLI.SelectedValue);
            gridAuto.DataSource = a.AutoVenduteGrid();
            gridAuto.DataBind();
        }
    }

    protected void gridAuto_SelectedIndexChanged(object sender, EventArgs e)
    {

        string ModificaTarga = gridAuto.SelectedRow.Cells[1].Text;
        Response.Redirect("ModificaAutoVendute.aspx?m=" + ModificaTarga);
    }
}