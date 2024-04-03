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


        }

    }

    protected void btnAutosalone_Click(object sender, EventArgs e)
    {
        //controllo dei campi
        if (txtIndirizzo.Text.Trim() == "" || txtIndirizzo.Text.Trim() == "")
        {
            lblErroreModelli.Text = "Riempi tutti Campi ";
            return;
        }
        //assegna i valori 
        AUTOSALONI a = new AUTOSALONI();
        a.Indirizzo = txtIndirizzo.Text.Trim();
        a.Cap = txtCap.Text.Trim();
        a.Citta = txtCitta.Text.Trim();
        a.Telefono = txtTelefono.Text.Trim();
        a.Cod_Venditore_Respons = int.Parse(txtCVResponsabile.Text);
        //controllo dell'autosalone 
        DataTable dt = a.ControlloAutoSaloni();
        if (dt.Rows.Count > 0)
        {
            lblErroreModelli.Text = "Autosalone già esistente";
            return;
        }
        a.AggiugiAS();
        Response.Redirect("RicercaAutoSaloni.aspx");
    }
}