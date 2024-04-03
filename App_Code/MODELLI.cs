using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Classi dei modelli
/// </summary>
public class MODELLI
{
    public int Cod_Modello;
    public int Cod_Marca;
    public string Modello;
    public string Allestimento;
    public string Alimentazione;

    public MODELLI()
    {

    }
    /// <summary>
    /// seleziona totti dati da modelli la marca uguale a quella selezionata dall`utente
    /// </summary>
    /// <returns>datatable</returns>
    public DataTable ddlModelli()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "ddlModelli";
        c.cmd.Parameters.AddWithValue("@Cod_Marca", Cod_Marca);
        c.EseguiSelect();

        return c.dt;
    }/// <summary>
    /// aggiunge un modello alla tabella dei modelli
    /// </summary>
    public void AggiungiModelli()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.cmd.Parameters.AddWithValue("@Cod_Marca", Cod_Marca);
        c.cmd.Parameters.AddWithValue("@Modello", Modello);
        c.cmd.Parameters.AddWithValue("@Allestimento", Allestimento);
        c.cmd.Parameters.AddWithValue("@Alimentazione", Alimentazione);

        c.querydicommando = "AggiungiModelli";

        c.EsequiCommand();
    }
    /// <summary>
    /// seleziona i dati da modelli ordinata per modello
    /// </summary>
    /// <returns>datatable</returns>
    //public DataTable GridAllModelli()
    //{
    //    CONNESSIONE c = new CONNESSIONE();
    //    c.querydiselezione = "GridAllModelli";
    //    c.EseguiSelect();
    //    return c.dt;
    //}
    /// <summary>
    /// seleziona i dati da modelli dove modello  e 
    /// come quella scritta dall`utente
    /// </summary>
    /// <returns>datatable</returns>
    public DataTable CercaModello()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.cmd.Parameters.AddWithValue("Cod_Marca", Cod_Marca);
        c.querydiselezione = "CercaModello";
        c.EseguiSelect();
        return c.dt;
    }
    /// <summary>
    /// salva(update) alla tabella un nuovo modello
    /// </summary>
    public void SalvaModello()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.cmd.Parameters.AddWithValue("@Modello", Modello);
        c.cmd.Parameters.AddWithValue("@Allestimento", Allestimento);
        c.cmd.Parameters.AddWithValue("@Alimentazione", Alimentazione);
        c.cmd.Parameters.AddWithValue("@Cod_Marca", Cod_Marca);
        c.cmd.Parameters.AddWithValue("@Cod_Modello", Cod_Modello);
        c.querydicommando = "SalvaModello";
        c.EsequiCommand();
    }

    /// <summary>
    /// seleziona i dati da modelli dove il cod_modello uguale a quella selezionata dall`utente
    /// </summary>
    /// <returns></returns>
    public DataTable ModificaModello()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "ModificaModello";
        c.cmd.Parameters.AddWithValue("@Cod_Modello", Cod_Modello);
        c.EseguiSelect();
        return c.dt;
    }
    /// <summary>
    /// seleziona i dati da modelli dove modello, cod_marca 
    /// e Alimentazione e` uguale scritta dall utente
    /// </summary>
    /// <returns></returns>
    public DataTable ControlloModello()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.cmd.Parameters.AddWithValue("@Modello",Modello);
        c.cmd.Parameters.AddWithValue("@Cod_Marca",Cod_Marca);
        c.cmd.Parameters.AddWithValue("@Alimentazione",Alimentazione);
        c.querydiselezione = "ControlloModello";
        c.EseguiSelect();
        return c.dt;
    }


}