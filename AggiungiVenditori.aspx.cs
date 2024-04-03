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
        DdlAutoSaloni();
    }

    protected void btnAggiungi_Click(object sender, EventArgs e)
    {
        // controllo dei campi
        if(txtCognome.Text =="" || txtNome.Text =="")
        {
            lblErrore.Text="Riempi i campi";
            return;
        }
        // assegna i valori
        VENDITORI v = new VENDITORI();
        v.Cognome = txtCognome.Text;
        v.Nome = txtNome.Text;
        v.Cod_Autosalone =int.Parse(ddlAutoSalone.SelectedValue);
        v.AggiungiVenditori();
        Response.Redirect("RicercaVenditori.aspx");
    }
    protected void DdlAutoSaloni()
    {   //caricari dati della ddl
        AUTOSALONI a = new AUTOSALONI();
        ddlAutoSalone.DataSource =a.GridAllAutoSaloni();
        ddlAutoSalone.DataTextField = "citta";
        ddlAutoSalone.DataValueField = "Cod_Autosalone";
        ddlAutoSalone.DataBind();


    }
}