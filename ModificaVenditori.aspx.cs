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
            DdlAutoSaloni();
            RiempiCampi();
        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        // controllo dei campi
        if(txtNome.Text.Trim() =="" || txtCognome.Text.Trim() =="")
        {
            lblErrore.Text = "Riempi i campi";
            return;
        }
        // assegnazione dei valori
        VENDITORI v = new VENDITORI();
        v.Cognome = txtCognome.Text.Trim();
        v.Nome = txtNome.Text.Trim();
        v.Cod_Autosalone = int.Parse(ddlAutoSalone.SelectedValue);
        v.Cod_Venditore = int.Parse(Request.QueryString["v"].ToString());
        //salva(update)
        v.ModificaVenditore();
        Response.Redirect("RicercaVenditori.aspx");
    }
    protected void RiempiCampi()
    {// riempi i campi da quello selezionato dall'utente
        int codice = int.Parse(Request.QueryString["v"].ToString());
        VENDITORI v = new VENDITORI();
        v.Cod_Venditore = codice;
        DataTable dt = v.CercaVenditore();
        txtCognome.Text = dt.Rows[0]["Cognome"].ToString();
        txtNome.Text = dt.Rows[0]["Nome"].ToString();
        ddlAutoSalone.SelectedValue = dt.Rows[0]["Cod_Autosalone"].ToString();


    }
    protected void DdlAutoSaloni()
    {
        // carica ddl
        AUTOSALONI a = new AUTOSALONI();
        ddlAutoSalone.DataSource = a.GridAllAutoSaloni();
        ddlAutoSalone.DataTextField = "citta";
        ddlAutoSalone.DataValueField = "Cod_Autosalone";
        ddlAutoSalone.DataBind();


    }
}