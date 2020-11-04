using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    public class Votazione
    {
        public double Valutazione;
        public DateTime Data { get; private set; }
        private Studente Studente;
        public Materia m { get; private set; }
        public Votazione(Materia m, Studente Studente, double valutazione)
        {
            this.m = m;
            this.Studente = Studente;
            this.Valutazione = valutazione;
        }
        public bool IsSufficente()
        {
            if (Valutazione <= 5.99)
            {
                return false;
            }else
                return true;
        }
        public  double GetVoto()
        {
            return Valutazione;
        }
        public string Descrizione(Votazione v)
        {
            return $"La valutazione d { v.Studente} in {v.m} è di {v.Valutazione} del {v.Data}";
        }
    }
}
