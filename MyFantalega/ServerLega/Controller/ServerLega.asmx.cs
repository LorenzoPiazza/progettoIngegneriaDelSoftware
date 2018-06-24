﻿using ServerLega.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServerLega.InterfacceController;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per ServerLega
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServerLega : System.Web.Services.WebService
    {

        [WebMethod]
        public Lega CreaLega(String nome, int numeroPartecipanti, Utente utente)
        {
            GestioneUtenteController gestioneUtenteController = new GestioneUtenteController();
            Lega lega = gestioneUtenteController.CreaLega(nome, numeroPartecipanti, utente);
            return lega;
        }

        public Boolean AbbandonaGiocatore(Asta asta, Squadra squadra)
        {
            IPartecipaAstaController partecipaAstaController = new PartecipaAstaController();
            return partecipaAstaController.AbbandonaGiocatore(asta, squadra);
        }

        public Boolean RialzaOfferta(Asta asta, Squadra squadra)
        {
            IPartecipaAstaController partecipaAstaController = new PartecipaAstaController();
            return partecipaAstaController.RialzaOfferta(asta, squadra);
        }
    }
}
