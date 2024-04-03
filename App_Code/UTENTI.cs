using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class UTENTI
{
    public string Cod_Utente;
    public string USR;
    public string PWD;

    public UTENTI()
    {

    }
    /// <summary>
    /// controllo su usr e pwd siano uguali 
    /// </summary>
    /// <returns>false se non ci sono valori
    /// true se i valori sono uguali</returns>
    public bool Login()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "Login";
        c.cmd.Parameters.AddWithValue("@USR", USR);
        c.cmd.Parameters.AddWithValue("@PWD", PWD);
        c.EseguiSelect();
        if (c.dt.Rows.Count == 0)
            return false;

        return true;

    }
}