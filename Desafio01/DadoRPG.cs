using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    class DadoRPG
    {
        public int QuantidadeDeLados { get; private set; }

        public DadoRPG(int quantidadeDeLados)
        {
            QuantidadeDeLados = quantidadeDeLados;
        }

        public int RolarDado()
        {
            Random random = new Random();
            return random.Next(1, this.QuantidadeDeLados + 1);
        }
    }
}
