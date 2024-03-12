using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Campionato_Calcio
{
    internal class Program
    {
        class Persona
        {
            private string _nome;
            public string Nome
            {
                get => _nome;
                set => _nome = value;
            }
            private string _cognome;
            public string Cognome
            {
                get => _cognome;
                set => _cognome = value;
            }
            public string _codice;
            public string Codice
            {
                get => _codice;
                set => _codice = value;
            }
            private Citta _citta;
            public Citta Citta
            {
                get => _citta;
                set => _citta = value;
            }
        }
        class Citta
        {
            private string _regione;
            public string Regione
            {
                get => _regione;
                set => _regione = value;
            }
            private string _nome;
            public string Nome
            {
                get => _nome;
                set => _nome = value;
            }
            private List<Persona> _abitanti;
            public List<Persona> Abitanti
            {
                get => _abitanti;
                set => _abitanti = value;
            }
            private List<Squadra> _squadre;
            public List<Squadra> Squadre
            {
                get => _squadre;
                set => _squadre = value;
            }
        }
        class Squadra
        {
            private Citta _citta;
            public Citta Citta
            {
                get => _citta;
                set => _citta = value;
            }
            private string _colori;
            public string Colori
            {
                get => _colori;
                set => _colori = value;
            }
            private string _nome;
            public string Nome
            {
                get => _nome;
                set => _nome = value;
            }
            private AllenatoreInPrima _primoallenatore;
            public AllenatoreInPrima PrimoAllenatore
            {
                get => _primoallenatore;
                set => _primoallenatore = value;
            }
            private AllenatoreInSeconda _secondoallenatore;
            public AllenatoreInSeconda Secondoallenatore
            {
                get => _secondoallenatore;
                set => _secondoallenatore = value;
            }
            private Calciatore _ngiocatori;
            public Calciatore nGiocatori
            {
                get => _ngiocatori;
                set => _ngiocatori = value;
            }
            private List<Partita> _partitaincasa;
            public List<Partita> PartitaInCasa
            {
                get => _partitaincasa;
                set => _partitaincasa = value;
            }
            private List<Partita> _partitaintrasferta;
            public List<Partita> PartitaInTrasferta
            {
                get => _partitaintrasferta;
                set => _partitaintrasferta = value;
            }
        }
        class Calciatore : Persona
        {
            private string _ruolo;
            public string Ruolo
            {
                get => _ruolo;
                set => _ruolo = value;
            }
            private Squadra _squadra;
            public Squadra Squadra
            {
                get => _squadra;
                set => _squadra = value;
            }
            public int Eta(DateTime oggi)
            {
                return 0;
            }
        }
        class Partita
        {
            private Arbitro _arbitro;
            public Arbitro Arbitro
            {
                get => _arbitro;
                set => _arbitro = value;
            }
            private DateTime _data;
            public DateTime Data
            {
                get => _data;
                set => _data = value;
            }
            private string _risultato;
            public string Risultato
            {
                get => _risultato;
                set => _risultato = value;
            }
        }
        class Arbitro : Persona
        {
            private List<Partita> _partita;
            public List<Partita> Partita
            {
                get => _partita;
                set => _partita = value;
            }
            public int Eta(DateTime oggi)
            {
                return 0;
            }
            public void UfficializzaRisultato()
            {
                
            }
        }
        class AllenatoreInPrima : Persona
        {
            private Squadra _squadra;
            public Squadra Squadra
            {
                get => _squadra;
                set => _squadra = value;
            }
        }
        class AllenatoreInSeconda : Calciatore
        {
            private Squadra _squadraallenata;
            public Squadra SquadraAllenata
            {
                get => _squadraallenata;
                set => _squadraallenata = value;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
