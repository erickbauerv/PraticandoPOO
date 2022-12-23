using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    class Contato
    {
        public string Nome { get; private set; }
        public string Numero { get; private set; }

        public Contato(string nome, string numero)
        {
            this.Nome = nome;
            this.Numero = numero;
        }
    }
}
