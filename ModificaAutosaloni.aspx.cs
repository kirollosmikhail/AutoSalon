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
            MettiValore();
        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        AUTOSALONI a = new AUTOSALONI();
        a.Indirizzo = txtInd.Text.Trim();
        a.Cap = txtCAP.Text.Trim();
        a.Citta = txtCitta.Text.Trim();
        a.Telefono = txtTelefono.Text.Trim();
        a.Cod_Venditore_Respons = int.Parse(txtCod_Venditore_Respons.Text);
        a.Cod_Autosalone = int.Parse(Request.QueryString["m"]);
        a.SalvaAS();
        Response.Redirect("RicercaAutoSaloni.aspx");
    }

    protected void MettiValore()
    {
        //seleziono la targa selezionata
        AUTOSALONI ats = new AUTOSALONI();
        ats.Cod_Autosalone = int.Parse(Request.QueryString["m"].ToString());
        DataTable dt = ats.GridAllAutoSaloni();
        //riempio i campi con i valori da DB
        txtCAP.Text = dt.Rows[0]["Cap"].ToString();
        txtInd.Text = dt.Rows[0]["Indirizzo"].ToString();
        txtCitta.Text = dt.Rows[0]["Citta"].ToString();
        txtTelefono.Text = dt.Rows[0]["Telefono"].ToString();
        txtCod_Venditore_Respons.Text = dt.Rows[0]["Cod_Venditore_Respons"].ToString();

    }
}