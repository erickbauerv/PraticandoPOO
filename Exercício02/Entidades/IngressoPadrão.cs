using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício02.Interfaces;

namespace Exercício02.Entidades
{
    public class IngressoPadrão : IIngresso
    {
        public double Valor { get; set; }

        public IngressoPadrão(double valor)
        {
            this.Valor = valor;
        }

        public string GerarExibicaoDeIngresso()
        {
            return  $"Tipo de ingresso: Ingresso padrão\n" +
                    $"Valor: {this.Valor}\n";
        }

        string IIngresso.GerarExibicaoDeIngresso()
        {
            throw new NotImplementedException();
        }
    }
}
