using Entidades.Exercício01;
using System;

namespace Exercício01
{
    class Program
    {
        static void Main(string[] args)
        {
            AssistenteAdministrativo funcionraio01 = new AssistenteAdministrativo("Leandro", 10000.00, "1234", "Noite");
            Funcionario funcionario02 = new AssistenteTecnico("Vitor", 9000.00, "4321");

            Console.WriteLine(funcionraio01.GerarExibicaoDeDados());
            Console.WriteLine();
            Console.WriteLine(funcionario02.GerarExibicaoDeDados());
            Console.ReadLine();
        }
    }
}
