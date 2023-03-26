using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício02.Enumeradores;
using Exercício02.Interfaces;

namespace Exercício02.Entidades
{
    public abstract class IngressoVIP : IIngresso
    {
        public static double ValorAdicionalVIP { get; private set; }
        public double Valor { get; set; }
        public TipoCamarote TipoCamarote { get; protected set; }

        public virtual string GerarExibicaoDeIngresso()
        {
            var camarote = this.TipoCamarote == TipoCamarote.CamaroteInferior ? "Camarote Inferior" 
                           : (this.TipoCamarote == TipoCamarote.CamaroteSuperior ? "Camarote Superior" : "");

            return  $"Tipo de ingresso: Ingresso VIP {camarote}\n" +
                    $"Valor: {this.Valor}\n";
        }

        public static void DefinirValorAdicionalVIO(double valorAdicionalVIP)
        {
            ValorAdicionalVIP = valorAdicionalVIP;
        }
    }
}
