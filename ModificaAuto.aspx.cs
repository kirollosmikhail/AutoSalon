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
            MettiValore();

        }


    }
    protected void MettiValore()
    {
        // riempi i campi selezionata dall'utente
        txtTarga.Text = Request.QueryString["m"].ToString();
        AUTOMOBILI a = new AUTOMOBILI();
        a.Targa = txtTarga.Text;
        DataTable dt = a.ModificaAuto();

        ddlMARCHE.SelectedValue = dt.Rows[0]["Cod_Marca"].ToString();
        CaricaModelli();
        ddlMODELLI.SelectedValue = dt.Rows[0]["Cod_Modello"].ToString();

        txtAnno.Text = dt.Rows[0]["Anno"].ToString();
        txtKM.Text = dt.Rows[0]["KM"].ToString();
        txtDescrizione.Text = dt.Rows[0]["Descrizione"].ToString();
        txtAutosalone.Text = dt.Rows[0]["Cod_Autosalone"].ToString();
        txtPrezzo.Text = dt.Rows[0]["Prezzo"].ToString();

        if (dt.Rows[0]["USATA_Nuova"].ToString() == "U")
            radUsata.Checked = true;
        else
            radNuova.Checked = true;

    }
    protected void ddlMARCHE_SelectedIndexChanged(object sender, EventArgs e)
    {
        CaricaModelli();
    }
    protected void CaricaMarche()
    {
        // carica i dati della ddl marche
        MARCHE m = new MARCHE();
        ddlMARCHE.DataSource = m.ddlMarche();
        ddlMARCHE.DataTextField = "Marca";
        ddlMARCHE.DataValueField = "Cod_Marca";
        ddlMARCHE.DataBind();
    }

    protected void CaricaModelli()
    {
        // carica i dati della ddl modelli
        MODELLI mo = new MODELLI();
        mo.Cod_Marca = int.Parse(ddlMARCHE.SelectedValue);
        ddlMODELLI.DataSource = mo.ddlModelli();
        ddlMODELLI.DataTextField = "mg";
        ddlMODELLI.DataValueField = "Cod_Modello";
        ddlMODELLI.DataBind();

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        // controllo dei campi
        if (txtTarga.Text.Trim() == "")
        {
            Response.Write("Riempi la targa");
            return;
        }
        //if (txtDescrizione.Text.Trim() == "")
        //{
        //    Response.Write("Riempi la descrizione");
        //    return;
        //}
        if (txtPrezzo.Text == "")
        {
            Response.Write("Riempi il prezzo");
            return;
        }
        if (radNuova.Checked == false && radUsata.Checked == false)
        {
            Response.Write("seleziona usata o nuova");
            return;
        }
        // assegna i valori
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

       
        //salva(update)
        a.SalvaAuto();
    }
}