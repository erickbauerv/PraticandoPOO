using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exercício01
{
    public class AssistenteTecnico : Funcionario
    {
        public double BonusSalarial { get; set; }

        public AssistenteTecnico(string nome, double salario, string numeroMatricula)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.NumeroMatricula = numeroMatricula;
            this.BonusSalarial = 1000;
        }

        public override string GerarExibicaoDeDados()
        {
            return  $"Nome: {Nome}\n" +
                    $"Salário: R${String.Format("{0:0.00}", this.Salario)}\n" +
                    $"Número de Matrícula: {NumeroMatricula}\n" +
                    $"Bônus salarial: R${String.Format("{0:0.00}", this.BonusSalarial)}\n";
        }
    }
}
