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
        
    }

    protected void btnMarca_Click(object sender, EventArgs e)
    {
        // controllo dei dati(campi utente)riempiti
        if (txtMarca.Text.Trim() == "")
            return;

        MARCHE m = new MARCHE();
        m.Marca = txtMarca.Text.Trim();
        DataTable dt = m.ControlloMarca();
        // controllo del dato se gia esistente
        if (dt.Rows.Count != 0)
        {
            lblErroreMarca.Text = "Marca gia esiste";
            return;
        }
        // aggiungo la marca e riporta alla pagina
        m.AggiungiMarca();
        Response.Redirect("RicercaMarche.aspx");

    }

}