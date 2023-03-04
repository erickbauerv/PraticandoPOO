using System;
using System.Text.RegularExpressions;

namespace Desafio05
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "0";

            while (menu != "5")
            {
                Console.WriteLine("Digite o tipo de operação:\n" +
                    "1 - Soma\n" +
                    "2 - Subtração\n" +
                    "3 - Multiplicação\n" +
                    "4 - Divisão\n" +
                    "5 - Sair");

                menu = Console.ReadLine();
                Console.Clear();

                if (menu == "5")
                {
                    Console.WriteLine("Saindo...");
                    break;
                }

                Console.WriteLine("Digite o primeiro valor: ");
                string stringValor1 = Console.ReadLine();
                Console.WriteLine("Digite o segundo valor: ");
                string stringValor2 = Console.ReadLine();

                bool valorValido = Regex.IsMatch(stringValor1, "^[0-9]+$") && Regex.IsMatch(stringValor2, "^[0-9]+$");

                if (valorValido)
                {
                    double valor1 = double.Parse(stringValor1);
                    double valor2 = double.Parse(stringValor2);
                    double resultado;

                    switch (menu)
                    {
                        case "1":
                            resultado = Calculadora.Somar(valor1, valor2);
                            Console.WriteLine(valor1 + " + " + valor2 + " = " + resultado);
                            break;
                        case "2":
                            resultado = Calculadora.Subtrair(valor1, valor2);
                            Console.WriteLine(valor1 + " - " + valor2 + " = " + resultado);
                            break;
                        case "3":
                            resultado = Calculadora.Multiplicar(valor1, valor2);
                            Console.WriteLine(valor1 + " * " + valor2 + " = " + resultado);
                            break;
                        case "4":
                            resultado = Calculadora.Divisao(valor1, valor2);
                            Console.WriteLine(valor1 + " / " + valor2 + " = " + resultado);
                            break;
                        default:
                            Console.WriteLine("Opção de operação inválida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Valores inválidos");
                }

                Console.ReadLine();
            }
        }
    }
}
