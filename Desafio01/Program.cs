using System;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            DadoRPG d4 = new DadoRPG(4);
            DadoRPG d6 = new DadoRPG(6);
            DadoRPG d8 = new DadoRPG(8);
            DadoRPG d10 = new DadoRPG(10);
            DadoRPG d12 = new DadoRPG(12);
            DadoRPG d20 = new DadoRPG(20);

            PrintarResultadoRolarDado(d4, d4.RolarDado());
            PrintarResultadoRolarDado(d6, d6.RolarDado());
            PrintarResultadoRolarDado(d8, d8.RolarDado());
            PrintarResultadoRolarDado(d10, d10.RolarDado());
            PrintarResultadoRolarDado(d12, d12.RolarDado());
            PrintarResultadoRolarDado(d20, d20.RolarDado());

            Console.ReadLine();
        }

        static void PrintarResultadoRolarDado(DadoRPG dadoRPG, int numero)
        {
            Console.WriteLine($"O dado de {dadoRPG.QuantidadeDeLados} lados caiu o número {numero}");
        }
    }
}
