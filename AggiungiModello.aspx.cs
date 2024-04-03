using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //carico ddl marche
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaMarche();
        }
    }

    protected void btnModello_Click(object sender, EventArgs e)
    {
        //controllo riempimento campi
        if (txtModello.Text.Trim() == "" || txtAlimentazione.Text.Trim() == "")
        {
            lblErroreModelli.Text = "Riempi tutti i campi";
            return;
        }
        //assegniamo ai parametri della classe i campi utente
        MODELLI mo = new MODELLI();
        mo.Cod_Marca = int.Parse(ddlMarca.SelectedValue);
        mo.Modello = txtModello.Text.Trim();
        mo.Alimentazione = txtAlimentazione.Text.Trim();
        mo.Allestimento = txtAllestimento.Text.Trim();
        //Controllo che il modello non esista già
        DataTable dt = mo.ControlloModello();
        if (dt.Rows.Count != 0)
        {
            lblErroreModelli.Text = "Questo modello esiste già";
            return;
        }
        //aggiungo modello e torno a pag principale
        mo.AggiungiModelli();
        Response.Redirect("RicercaModelli.aspx");
    }

    //procedure per caricare ddlMarche
    protected void CaricaMarche()
    {
        MARCHE m = new MARCHE();
        ddlMarca.DataSource = m.ddlMarche();
        ddlMarca.DataTextField = "Marca";
        ddlMarca.DataValueField = "Cod_Marca";
        ddlMarca.DataBind();
    }


}