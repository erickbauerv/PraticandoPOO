using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício02.Enumeradores;

namespace Exercício02.Entidades
{
    public class IngressoVIPCamaroteSuperior : IngressoVIP
    {
        public static double ValorAdicionalCamaroteSuperior { get; private set; }

        public IngressoVIPCamaroteSuperior(double valor)
        {
            this.Valor = valor + ValorAdicionalVIP + ValorAdicionalCamaroteSuperior;
            this.TipoCamarote = TipoCamarote.CamaroteSuperior;
        }

        public static void DefinirValorAdicionalCamaroteSuperior(double valorAdicionalCamaroteSuperior)
        {
            ValorAdicionalCamaroteSuperior = valorAdicionalCamaroteSuperior;
        }
    }
}
