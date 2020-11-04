using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Scuola
{
    public class Materia
    {
        public string Nome { get; private set; }
        public Materia(string nome)
        {
            this.Nome = nome;
        }
    }
}
