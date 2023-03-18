using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exercício01
{
    public class AssistenteAdministrativo : Funcionario
    {
        public string Turno { get; set; }
        public double AdicionalNoturno { get; set; }

        public AssistenteAdministrativo(string nome, double salario, string numeroMatricula, string turno)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.NumeroMatricula = numeroMatricula;
            this.Turno = turno;
            this.AdicionalNoturno = 100;
        }

        public override string GerarExibicaoDeDados()
        {
            return  $"Nome: {Nome}\n" +
                    $"Salário: R${String.Format("{0:0.00}", this.Salario)}\n" +
                    $"Número de Matrícula: {NumeroMatricula}\n" +
                    $"Turno: {Turno}\n" +
                    $"Adicional noturno: R${String.Format("{0:0.00}", this.AdicionalNoturno)}";
        }
    }
}
