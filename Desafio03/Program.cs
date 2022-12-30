using System;

namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "0";
            ContaBancaria contaBancaria = new ContaBancaria("Rogério", "8324098347194");

            while (menu != "4")
            {
                Console.WriteLine("1 - Depositar\n2 - Sacar\n3 - Consultar transações\n4 - Sair");
                menu = Console.ReadLine();
                Console.Clear();

                switch (menu)
                {
                    case "1":
                        Console.WriteLine("Digite o valor que será depositado");
                        double valorSacar = double.Parse(Console.ReadLine());
                        contaBancaria.Depositar(valorSacar);
                        break;
                    case "2":
                        Console.WriteLine("Digite o valor que será sacado");
                        double valorDepositar = double.Parse(Console.ReadLine());
                        contaBancaria.Sacar(valorDepositar);
                        break;
                    case "3":
                        contaBancaria.ConsultarTransacoes();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
