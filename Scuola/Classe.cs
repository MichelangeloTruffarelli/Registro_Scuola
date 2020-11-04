using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    public class Classe
    {
        private int Anno;
        private string Sezine;
        List<Studente> studenti = new List<Studente>();
        public Classe(int anno, string sezione)
        {
            this.Anno = anno;
            this.Sezine = sezione;
        }
        public string GetNome()
        {
            string annostring = Anno.ToString();
            return annostring + Sezine;
        }
    }
}
