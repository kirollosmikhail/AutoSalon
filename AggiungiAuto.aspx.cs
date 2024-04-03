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
            CaricaMarche();
    }
    // controllare se tutti i campi i pieni se tutti i dati pieni crea una nuova macchina
    protected void btnAggiungi_Click(object sender, EventArgs e)
    {

        if (txtTarga.Text.Trim() == "")
        {
            lblErrore.Text ="Riempi la targa";
            return;
        }
        if (txtDescrizione.Text.Trim() == "")
        {
            lblErrore.Text ="Riempi la descrizione";
            return;
        }
        if (txtPrezzo.Text == "")
        {
            lblErrore.Text ="Riempi il prezzo";
            return;
        }
        if (radNuova.Checked == false && radUsata.Checked == false)
        {
            lblErrore.Text ="seleziona usata o nuova";
            return;
        }
        // assegna valore
        AUTOMOBILI a = new AUTOMOBILI();

        a.Targa = txtTarga.Text;
        a.Descrizione = txtDescrizione.Text;
        a.Anno = int.Parse(txtAnno.Text);
        a.KM = int.Parse(txtKM.Text);
        a.Cod_Autosalone = int.Parse(txtAutosalone.Text);
        a.Cod_Modello = int.Parse(ddlMODELLI.SelectedValue);
        a.Prezzo = decimal.Parse(txtPrezzo.Text);
        if (radUsata.Checked == true)
            a.Usata_Nuova = 'U';
        else
            a.Usata_Nuova = 'N';
        //aggiunge l'auto
        a.AggiungiAuto();
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Errore", "alert('Auto Aggiunta correttamente');", true);


    }
    
   
    // carica dropdownlist marca
    protected void CaricaMarche()
    {

        MARCHE m = new MARCHE();
        ddlMARCHE.DataSource = m.ddlMarche();
        ddlMARCHE.DataTextField = "Marca";
        ddlMARCHE.DataValueField = "Cod_Marca";
        ddlMARCHE.DataBind();
    }
    // carica dropdownlist modelli 
    protected void CaricaModelli()
    {
        MODELLI mo = new MODELLI();
        mo.Cod_Marca = int.Parse(ddlMARCHE.SelectedValue);
        ddlMODELLI.DataSource = mo.ddlModelli();
        ddlMODELLI.DataTextField = "mg";
        ddlMODELLI.DataValueField = "Cod_Modello";
        ddlMODELLI.DataBind();

    }
    // cambia il valore in base alla ddlmarche 
    protected void ddlMARCHE_SelectedIndexChanged(object sender, EventArgs e)
    {
        CaricaModelli();
    }
}