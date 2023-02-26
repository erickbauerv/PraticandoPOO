using System;

namespace Desafio04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data data01 = new Data(1, 1, 2001);
            // Console.WriteLine($"Dia: {data01.Dia}, Mês: {data01.Mes}, Ano: {data01.Ano}");

            Data data02 = new Data("31/12/2002");
            data02.ImprimirData();

            data02.AdicionarDias(2);
            data02.ImprimirDataFormatada();

            Console.ReadLine();
        }
    }
}
