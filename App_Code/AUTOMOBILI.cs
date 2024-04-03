using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// CLASSE dati automobili 
/// </summary>
public class AUTOMOBILI
{
    public string Targa;
    public int Cod_Modello;
    public int Anno;
    public char Usata_Nuova ;
    public int KM;
    public string Descrizione;
    public int Cod_Autosalone;
    public DateTime Data_Vendita;
    public int Cod_Venditore;
    public decimal Prezzo;


    public AUTOMOBILI()
    {
        
    }
    /// <summary>
    /// Seleziona tutti i dati da automobili dove deve cod_Modello seleziontato che ritorna su datatable
    /// </summary>
    /// <returns>retorno una datatable</returns>
    public DataTable AutoGrid()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "AutoGrid";
        c.cmd.Parameters.AddWithValue("@Cod_Modello", Cod_Modello);
        c.EseguiSelect();

        return c.dt;
    }
    /// <summary>
    /// seleziona tutte le auto
    /// </summary>
    /// <returns>datatable</returns>
    public DataTable GridAllAuto()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "GridAllAuto";
        c.EseguiSelect();

        return c.dt;
    }
    /// <summary>
    /// aggiunge auto alla tabella da parte dell`utente
    /// </summary>
    public void AggiungiAuto()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicommando = "AggiungiAuto";
        c.cmd.Parameters.AddWithValue("@Targa", Targa);
        c.cmd.Parameters.AddWithValue("@Cod_Modello", Cod_Modello);
        c.cmd.Parameters.AddWithValue("@Anno", Anno);
        c.cmd.Parameters.AddWithValue("@USATA_Nuova", Usata_Nuova);
        c.cmd.Parameters.AddWithValue("@KM", KM);
        c.cmd.Parameters.AddWithValue("@Descrizione", Descrizione);
        c.cmd.Parameters.AddWithValue("@Cod_Autosalone", Cod_Autosalone);
        c.cmd.Parameters.AddWithValue("@Prezzo", Prezzo);
        c.EsequiCommand();

    }
    /// <summary>
    /// seleziona l`auto selezionata dall`utente 
    /// </summary>
    /// <returns>ritorno datatable su una sola riga</returns>
    public DataTable ModificaAuto()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.cmd.Parameters.AddWithValue("@Targa", Targa);
        c.querydiselezione = "ModificaAuto";
        c.EseguiSelect();

        

        return c.dt;
    }
    /// <summary>
    /// update dell`auto selezionata
    /// </summary>
    public void SalvaAuto()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.cmd.Parameters.AddWithValue("@Targa",Targa);
        c.cmd.Parameters.AddWithValue("@Cod_Modello",Cod_Modello);
        c.cmd.Parameters.AddWithValue("@Anno",Anno);
        c.cmd.Parameters.AddWithValue("@USATA_Nuova",Usata_Nuova);
        c.cmd.Parameters.AddWithValue("@KM",KM);
        c.cmd.Parameters.AddWithValue("@Descrizione",Descrizione);
        c.cmd.Parameters.AddWithValue("@Cod_Autosalone",Cod_Autosalone);
        c.cmd.Parameters.AddWithValue("@Prezzo",Prezzo);
        if(Cod_Venditore == 0)
        {
            Data_Vendita = DateTime.Now;
            Cod_Venditore = 0;
        }
        c.cmd.Parameters.AddWithValue("@Cod_Venditore", Cod_Venditore);
        c.cmd.Parameters.AddWithValue("@DataVendita", Data_Vendita);



        c.querydicommando = "SalvaAuto";
        c.EsequiCommand();

    }

    public DataTable GridAllVendute()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "GridAllVendute";
        c.EseguiSelect();

        return c.dt;
    }

    public DataTable Ricavi()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "Ricavi";
        c.cmd.Parameters.AddWithValue("@Cod_Autosalone",Cod_Autosalone);
        c.EseguiSelect();

        return c.dt;
    }
    public DataTable AutoVenduteGrid()
    {

        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "AutoVenduteGrid";
        c.EseguiSelect();

        return c.dt;

    }

}