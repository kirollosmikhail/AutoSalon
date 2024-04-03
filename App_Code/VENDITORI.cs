using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class VENDITORI
{
    public int Cod_Venditore;
    public string Cognome;
    public string Nome;
    public int Cod_Autosalone;

    public VENDITORI()
    {
    }
    /// <summary>
    /// seleziona i dati da venditori
    /// </summary>
    /// <returns>datatable</returns>
    public DataTable GridAllVenditori()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "GirdAllVenditori";
        c.EseguiSelect();
        return c.dt;
    }
    /// <summary>
    /// seleziona dati da venditori dove nome e` come quella scritta della utente
    /// </summary>
    /// <returns></returns>
    public DataTable CercaVenditori()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "CercaVenditori";
        c.cmd.Parameters.AddWithValue("Nome", Nome);
        c.EseguiSelect();
        return c.dt;
    }
    /// <summary>
    /// aggiunge un venditore alla tabella venditori
    /// </summary>
    public void AggiungiVenditori()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicommando = "AggiungiVenditori";
        c.cmd.Parameters.AddWithValue("@Cognome", Cognome);
        c.cmd.Parameters.AddWithValue("@Nome", Nome);
        c.cmd.Parameters.AddWithValue("@Cod_Autosalone", Cod_Autosalone);
        c.EsequiCommand();
        
    }
    /// <summary>
    /// seleziona dati da venditori dove cod_venditore
    /// e` uguale a quella selezionata dall'utente
    /// </summary>
    /// <returns></returns>
    public DataTable CercaVenditore()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "CercaVenditore";
        c.cmd.Parameters.AddWithValue("@Cod_Venditore", Cod_Venditore);
        c.EseguiSelect();
        return c.dt;
    }
    /// <summary>
    /// salva(update) dati della tabella venditori
    /// </summary>
    public void ModificaVenditore()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicommando = "ModificaVenditore";
        c.cmd.Parameters.AddWithValue("@Cod_Venditore", Cod_Venditore);
        c.cmd.Parameters.AddWithValue("@Cognome", Cognome);
        c.cmd.Parameters.AddWithValue("@Nome", Nome);
        c.cmd.Parameters.AddWithValue("@Cod_Autosalone", Cod_Autosalone);
        c.EsequiCommand();
    }
    public DataTable DdlVenditori()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "Ddlvenditori";
        c.EseguiSelect();
        return c.dt;
    }


}