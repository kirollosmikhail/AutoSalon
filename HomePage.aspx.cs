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
    protected void CaricaMarche()
    {
        // carica i dati alla ddl marche
        MARCHE m = new MARCHE();
        ddlMARCHE.DataSource = m.ddlMarche();
        ddlMARCHE.DataTextField = "Marca";
        ddlMARCHE.DataValueField = "Cod_Marca";
        ddlMARCHE.DataBind();
    }

    protected void CaricaModelli()
    {
        // carica i dati alla ddl modelli
        MODELLI mo = new MODELLI();
        mo.Cod_Marca = int.Parse(ddlMARCHE.SelectedValue);
        ddlMODELLI.DataSource = mo.ddlModelli();
        ddlMODELLI.DataTextField = "mg";
        ddlMODELLI.DataValueField = "Cod_Modello";
        ddlMODELLI.DataBind();

    }

    
    protected void Reset()
    {
        // ricarica tutti auto e mette nella griglia
        AUTOMOBILI a = new AUTOMOBILI();
        gridRisultati.DataSource = a.GridAllAuto();

        gridRisultati.DataBind();
        ddlMARCHE.SelectedIndex = 0;
        if (ddlMODELLI.SelectedIndex < 0)return;

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
            gridRisultati.DataSource = a.AutoGrid();
            gridRisultati.DataBind();
        }
    }
}