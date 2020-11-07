using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    class Docente
    {
        private string nome;
        private string cognome;
        List<Materia> materie = new List<Materia>();
        List<Votazione> voti = new List<Votazione>();
        

        public Docente(string nome, string cognome,Materia materia, Classe c)
        {
            this.nome = nome;
            this.cognome = cognome;
            materie.Add(materia);
        }

        public string GetNome(String value)
        {
            nome = value;
            return nome;
        }

        public string GetCognome(String value)
        {
            cognome = value;
            return cognome;
        }

        public List<Materia> GetMaterie()
        {
            return materie;
        }

        public void AssegnaVoto(Studente studente, Votazione voto)
        {
            studente.AddVoto(voto);
            voti.Add(voto);
        }

        public Votazione TrovaVotoMassimo()
        {
            Votazione max = voti[0];
            foreach(Votazione v in voti)
            {
                if (v.GetVoto() > max.GetVoto())
                    max = v;
            }return max;
        }
    }
}
