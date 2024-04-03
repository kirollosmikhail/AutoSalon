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
        if (!IsPostBack)
        {
            CaricaMarche();
            Reset();
            ddlMarche.Items.Insert(0, new ListItem("Select Marca", "NA"));
            ddlMarche.SelectedIndex = 0;
        }
    }
    
    // per caricare tutti marche
    protected void CaricaMarche()
    {
        MARCHE m = new MARCHE();
        ddlMarche.DataSource = m.ddlMarche();
        ddlMarche.DataTextField = "Marca";
        ddlMarche.DataValueField = "Cod_Marca";
        ddlMarche.DataBind();
    }
    // riporta i dati dei modelli
    protected void Reset()
    {
        MODELLI mo = new MODELLI();
        gridModelli.DataSource = mo.CercaModello();
        gridModelli.DataBind();

    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Reset();
        ddlMarche.SelectedIndex = 0;
    }

    protected void btnAggiungi_Click(object sender, EventArgs e)
    {
        Response.Redirect("AggiungiModello.aspx");
    }
    
    protected void gridModelli_SelectedIndexChanged(object sender, EventArgs e)
    {
        string codice = gridModelli.SelectedValue.ToString();
        Response.Redirect("ModificaModelli.aspx?m=" + codice);

    }

    protected void ddlMarche_SelectedIndexChanged(object sender, EventArgs e)
    {
        MODELLI mo = new MODELLI();
        mo.Cod_Marca = int.Parse(ddlMarche.SelectedValue);
        gridModelli.DataSource = mo.CercaModello();
        gridModelli.DataBind();
    }
}