using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício02.Interfaces
{
    public interface IIngresso
    {
        public double Valor { get; set; }
        public string GerarExibicaoDeIngresso();
    }
}
