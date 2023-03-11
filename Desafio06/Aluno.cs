using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio06
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public float NotaA { get; private set; }
        public float NotaB { get; private set; }
        public bool Aprovado { get; set; }

        public Aluno(string nome)
        {
            this.Nome = nome;
        }

        public void AdicionarNotas(float notaA, float notaB)
        {
            this.NotaA = notaA;
            this.NotaB = notaB;

            double media = ((NotaA * 1) + (NotaB * 2)) / 2;
            this.Aprovado = media > 5 ? true : false;
        }
    }
}
