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
        }
        static void Main(string[] args)
        {
        }
    }
}
