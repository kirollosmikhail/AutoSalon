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
        {
            CaricaMarche();
            RiempiCampi();

        }
    }

    protected void btnModello_Click(object sender, EventArgs e)
    {
        // assegna i valori
        MODELLI mo = new MODELLI();
        mo.Cod_Marca = int.Parse(ddlMarca.SelectedValue);
        mo.Modello = txtModello.Text;
        mo.Alimentazione = txtAlimentazione.Text;
        mo.Allestimento = txtAllestimento.Text;
        mo.Cod_Modello = int.Parse(Request.QueryString["m"]);
        // salva(update) e riporta alla pagina
        mo.SalvaModello();
        Response.Redirect("RicercaModelli.aspx");
    }

    protected void CaricaMarche()
    {
        // riempi la ddl
        MARCHE m = new MARCHE();
        ddlMarca.DataSource = m.ddlMarche();
        ddlMarca.DataTextField = "Marca";
        ddlMarca.DataValueField = "Cod_Marca";
        ddlMarca.DataBind();
    }

    protected void RiempiCampi()
    {
        // riempi i campi da quello selezionato
        MODELLI mo = new MODELLI();
        mo.Cod_Modello = int.Parse(Request.QueryString["m"]);
        DataTable dt = mo.ModificaModello();
        txtModello.Text = dt.Rows[0]["Modello"].ToString();
        txtAlimentazione.Text = dt.Rows[0]["Alimentazione"].ToString();
        txtAllestimento.Text = dt.Rows[0]["Allestimento"].ToString();
        ddlMarca.SelectedValue = dt.Rows[0]["Cod_Marca"].ToString();
    }
}