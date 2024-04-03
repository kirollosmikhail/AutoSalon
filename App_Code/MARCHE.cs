using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Classe con dati MARCHE
/// </summary>
public class MARCHE
{
    public int Cod_Marca;
    public string Marca;

    public MARCHE()
    {
    }
    /// <summary>
    /// seleziona tutti i dati di Marche ordinate per Marca
    /// </summary>
    /// <returns>datatable</returns>
    public DataTable ddlMarche()
    {
        CONNESSIONE c = new CONNESSIONE();
        
        c.querydiselezione = "ddlMarche";
        c.EseguiSelect();
        return c.dt;
    }
    /// <summary>
    /// seleziona La marca dove la marca e` uguale a quella selezionata dell`utente
    /// </summary>
    /// <returns>datatable</returns>
    public DataTable ControlloMarca()
    {
        CONNESSIONE c = new CONNESSIONE();

        c.querydiselezione = "ControlloMarca";
        c.cmd.Parameters.AddWithValue("@Marca", Marca);
        c.EseguiSelect();
        return c.dt;
    }
    /// <summary>
    /// aggiunge marca nella tabella marche
    /// </summary>
    public void AggiungiMarca()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.cmd.Parameters.AddWithValue("@Marca", Marca);
        c.querydicommando = "AggiungiMarca";
        c.EsequiCommand();
        
    }
    /// <summary>
    /// seleziona la marca dove la marca e 
    /// </summary>
    /// <returns></returns>
    public DataTable CercaMarca()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "CercaMarca";
        c.cmd.Parameters.AddWithValue("@Marca", Marca);
        c.EseguiSelect();
        return c.dt;
    }
    /// <summary>
    /// seleziona i dati della marca dove cod_marca e ugal
    /// </summary>
    /// <returns></returns>
    public DataTable ModificaMarca()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "ModificaMarca";
        c.cmd.Parameters.AddWithValue("@Cod_Marca",Cod_Marca);
        c.EseguiSelect() ;
        return c.dt;
    }
    /// <summary>
    /// salva(update) la marca
    /// </summary>
    public void SalvaMarca()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicommando = "SalvaMarca";
        c.cmd.Parameters.AddWithValue("@Marca",Marca);
        c.cmd.Parameters.AddWithValue("@Cod_Marca",Cod_Marca);
        c.EsequiCommand();

    }

}