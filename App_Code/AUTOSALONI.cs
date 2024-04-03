using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// dati che ci sono nella tabella
/// </summary>
public class AUTOSALONI
{
    public int Cod_Autosalone;
    public string Indirizzo;
    public string Cap;
    public string Citta;
    public string Telefono;
    public int Cod_Venditore_Respons;

   
    public AUTOSALONI()
    {

    }
    /// <summary>
    /// seleziona i dati di autosaloni
    /// </summary>
    /// <returns>datatable</returns>
    public DataTable GridAllAutoSaloni()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydiselezione = "GridAllAutoSaloni";
        c.EseguiSelect();
        return c.dt;
    }

    public void AggiugiAS()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicommando = "AggiungiAS";
        c.cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
        c.cmd.Parameters.AddWithValue("@Cap", Cap);
        c.cmd.Parameters.AddWithValue("@Citta", Citta);
        c.cmd.Parameters.AddWithValue("@Telefono", Telefono);
        c.cmd.Parameters.AddWithValue("@Cod_Venditore_Respons", Cod_Venditore_Respons);
        c.EsequiCommand();

    }
    public DataTable ControlloAutoSaloni()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.cmd.Parameters.AddWithValue("@Citta", Citta);

        c.querydiselezione = "ControlloAutoSaloni";
        c.EseguiSelect();
        return c.dt;
    }


    public void SalvaAS()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.querydicommando = "SalvaAS";
        c.cmd.Parameters.AddWithValue("@Cod_Autosalone", Cod_Autosalone);
        c.cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
        c.cmd.Parameters.AddWithValue("@CAP", Cap);
        c.cmd.Parameters.AddWithValue("@Citta", Citta);
        c.cmd.Parameters.AddWithValue("@Telefono", Telefono);
        c.cmd.Parameters.AddWithValue("@Cod_Venditore_Respons", Cod_Venditore_Respons);
        c.EsequiCommand();
    }
    public DataTable ModificaAS()
    {
        CONNESSIONE c = new CONNESSIONE();
        c.cmd.Parameters.AddWithValue("@Cod_Autosalone", Cod_Autosalone);
        c.querydiselezione = "ModificaAS";
        c.EseguiSelect();

        return c.dt;

    }



}