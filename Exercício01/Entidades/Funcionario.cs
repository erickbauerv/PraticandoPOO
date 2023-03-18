using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exercício01
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public string NumeroMatricula { get; set; }

        public abstract string GerarExibicaoDeDados();
    }
}
