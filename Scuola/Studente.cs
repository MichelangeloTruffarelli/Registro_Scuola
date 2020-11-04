using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    public class Studente
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public DateTime DataNascita { get; private set; }
        public List<Votazione> Voti { get; private set; }
        public Studente(string nome ,string cognome)
        {
            this.Nome = nome;
            this.Cognome = cognome;
        }
        public void AddVoto ( Votazione v)
        {
            Voti.Add(v);
        }
        public string NomeCompleto ( Studente s)
        {
            return $"{s.Cognome}{s.Nome}, nato il {s.DataNascita}";
        }
    }
}
