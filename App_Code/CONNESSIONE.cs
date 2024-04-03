using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per connessione
/// crea connessione con database
/// </summary>
public class CONNESSIONE
{
    public SqlConnection conn = new SqlConnection();
    public SqlCommand cmd = new SqlCommand();
    public SqlDataAdapter DA = new SqlDataAdapter();
    public DataTable dt = new DataTable();
    public string querydiselezione;
    public string querydicommando;

    /// <summary>
    /// crea connessione
    /// </summary>
    public CONNESSIONE()
    {
        conn.ConnectionString = "Data Source =. ; initial catalog =CONCESSIONARIA; integrated security = true;";
        cmd.Connection = conn;
    }
    /// <summary>
    /// esegui una selezione dal database
    /// </summary>
    public void EseguiSelect()
    {
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = querydiselezione;
        DA.SelectCommand = cmd;
        DA.Fill(dt);
    }
    /// <summary>
    /// esegui comando 
    /// </summary>
    public void EsequiCommand()
    {
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = querydicommando;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

}