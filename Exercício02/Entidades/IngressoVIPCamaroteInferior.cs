using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício02.Enumeradores;

namespace Exercício02.Entidades
{
    public class IngressoVIPCamaroteInferior : IngressoVIP
    {
        public string LocalCanarote { get; private set; }

        public IngressoVIPCamaroteInferior(double valor, string localCamarote)
        {
            this.Valor = valor + ValorAdicionalVIP;
            this.LocalCanarote = localCamarote;
            this.TipoCamarote = TipoCamarote.CamaroteInferior;
        }

        public override string GerarExibicaoDeIngresso()
        {
            return base.GerarExibicaoDeIngresso() + $"Local: {this.LocalCanarote}\n";
        }
    }
}
