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
            RiempiCampi();
        }
    }

    protected void btnMarca_Click(object sender, EventArgs e)
    {
        //salva (update)
        MARCHE m = new MARCHE();
        m.Cod_Marca = int.Parse(Request.QueryString["m"]);
        m.Marca = txtMarca.Text.Trim();
        m.SalvaMarca();
        Response.Redirect("RicercaMarche.aspx");

    }
    protected void RiempiCampi()
    {
        //riempi i campi dai dati selezionato dall'utente
        int codici = int.Parse(Request.QueryString["m"]);
        MARCHE m = new MARCHE();
        m.Cod_Marca = codici;
        DataTable dt = m.ModificaMarca();
        txtMarca.Text = dt.Rows[0]["Marca"].ToString();
    }
}