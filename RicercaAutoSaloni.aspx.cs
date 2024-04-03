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
        {
            RiempiDdl();
            Reset();


        }
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Reset();
    }

    protected void Reset()
    {
        AUTOSALONI a = new AUTOSALONI();
        gridAS.DataSource = a.GridAllAutoSaloni();
        gridAS.DataBind();
    }
    protected void RiempiDdl()
    {
        AUTOSALONI a = new AUTOSALONI();
        ddLAS.DataSource = a.GridAllAutoSaloni();
        ddLAS.DataTextField = "Citta";
        ddLAS.DataValueField = "Cod_Autosalone";
        ddLAS.DataBind();
    }

    protected void gridAS_SelectedIndexChanged(object sender, EventArgs e)
    {
        string codice = gridAS.SelectedValue.ToString();
        Response.Redirect("ModificaAutosaloni.aspx?m=" + codice);
    }
}