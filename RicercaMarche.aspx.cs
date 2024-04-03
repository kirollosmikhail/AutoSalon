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

        // resetta i valori
        if(!IsPostBack)
        {
            Reset();
        }

    }
    //dati di marche filterate per marca
    protected void btnMarca_Click(object sender, EventArgs e)
    {
        MARCHE m = new MARCHE();
        m.Marca = txtMarca.Text.Trim();
        gridMarce.DataSource=m.CercaMarca();
        gridMarce.DataBind();
    }
   
    // riporta alla pagina aggiungimarca.aspx
    protected void btnAggiungi_Click(object sender, EventArgs e)
    {
        Response.Redirect("AggiungiMarca.aspx");
    }
    protected void Reset()
    {
        MARCHE m = new MARCHE();
        gridMarce.DataSource=m.ddlMarche();
        gridMarce.DataBind();

    }

    protected void gridMarce_SelectedIndexChanged(object sender, EventArgs e)
    {
        string codici = gridMarce.SelectedValue.ToString();
        Response.Redirect("ModificaMarche.aspx?m=" + codici);
    }
}