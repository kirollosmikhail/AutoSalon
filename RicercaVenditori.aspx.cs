using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            Reset();
    }
   
    // riporta i dati alla griglia
    protected void Reset()
    {
        VENDITORI v = new VENDITORI();
        gridVenditori.DataSource = v.GridAllVenditori();
        gridVenditori.DataBind();
    }

    // riporta i dati venditori filtirati per nome 
    protected void btnNome_Click(object sender, EventArgs e)
    {
        VENDITORI v = new VENDITORI();
        v.Nome = txtNome.Text.Trim();
        gridVenditori.DataSource = v.CercaVenditori();
        gridVenditori.DataBind();
    }

    protected void btnAggiungi_Click(object sender, EventArgs e)
    {
        Response.Redirect("AggiungiVenditori.aspx");
    }

    protected void gridVenditori_SelectedIndexChanged(object sender, EventArgs e)
    {
        string Cod_Venditori = gridVenditori.SelectedRow.Cells[1].Text;
        Response.Redirect("ModificaVenditori.aspx?v=" + Cod_Venditori);
    }
}