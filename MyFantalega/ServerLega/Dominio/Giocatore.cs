﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLega.Dominio
{
    public class Giocatore
    {
        private String _nome;
        private int _quotazioneIniziale;
        private String _ruolo;
        private String _club;
        private Stato _stato = null;
        //field che seguono sono indispensabili per determinare lo stato
        private String _nomeSquadra;    //squadra che ha acquistato il giocatore
        private int _prezzoAcquisto;

        public Giocatore()
        {
            //valori di default assegnati a giocatore con stato Libero
            //Si assume che un giocatore alla creazione sia libero
            //_nomeSquadra = "ListaSvincolati";
            //_prezzoAcquisto = 0;
            //StateChanged();
        }


        public Giocatore(String nome, int quotazioneI, String ruolo, String club)
        {
            if (nome == null || nome.Length == 0)
            {
                throw new ArgumentException("nome nullo");
            }
            if (quotazioneI <= 0)
            {
                throw new ArgumentException("quotazioneIniziale <= 0");
            }
            if (ruolo == null || ruolo.Length == 0)
            {
                throw new ArgumentException("ruolo nullo");
            }

            _nome = nome;
            _quotazioneIniziale = quotazioneI;
            _ruolo = ruolo;
            _club = club;


            //valori di default assegnati a giocatore con stato Libero
            //Si assume che un giocatore alla creazione sia libero
            _nomeSquadra = "ListaSvincolati";
            _prezzoAcquisto = 0;
            StateChanged();
        }
        public string NomeSquadra
        {
            get
            {
                if (_stato != null && _stato.Nome.Equals("Acquistato")){
                    return NomeSquadra;
                }
                else return "ListaSvincolati";  
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new ArgumentException("Nome Squadra acquirente nullo");
                if (value != _nomeSquadra)
                {
                    _nomeSquadra = value;
                    StateChanged();
                }
            }
        }
        public int PrezzoAcquisto
        {
            get
            {
                if (_stato != null && _stato.Nome.Equals("Acquistato"))
                {
                    return PrezzoAcquisto;
                }
                else return 0;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("prezzo di Acquisto < 0");
                if (value != _prezzoAcquisto)
                {
                    _prezzoAcquisto = value;
                    StateChanged();
                }
            }
        }


        public String Nome { get => _nome; set => _nome = value; }
        public int QuotazioneIniziale { get => _quotazioneIniziale; set => _quotazioneIniziale = value; }
        public String Ruolo { get => _ruolo; set => _ruolo = value; }
        public String Club { get => _club; set => _club = value; }



        private void StateChanged()
        {
            _stato = Stato.DeterminaStato(this);
        }

    }
}

