using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Desafio06
{
    class Program
    {
        static void Main(string[] args)
        {
            byte menu = 0;
            Turma turma = new Turma("Programação Orientada a Objetos");

            while (menu != 5)
            {
                Console.WriteLine(
                    "1 - Adicionar aluno\n" +
                    "2 - Remover aluno\n" +
                    "3 - Lançar notas\n" +
                    "4 - Imprimir as relações dos alunos\n" +
                    "5 - Sair");

                string menuString = Console.ReadLine();
                bool valorValido = Regex.IsMatch(menuString, "^[0-9]+$");
                
                if (valorValido)
                {
                    menu = byte.Parse(menuString);
                    Console.Clear();
                }

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do aluno: ");
                        Aluno aluno = new Aluno(Console.ReadLine());
                        turma.AdicionarAluno(aluno);
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do aluno:");
                        turma.RemoverAlunoPorNome(Console.ReadLine());
                        break;
                    case 3:
                        TelaLancarNotas(turma);
                        break;
                    case 4:
                        Console.WriteLine(turma.GerarAproveitamentoDosAlunos());
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.ReadLine();
            }
        }

        public static void TelaLancarNotas(Turma turma)
        {
            foreach (Aluno aluno in turma.Alunos)
            {
                Console.WriteLine($"\nAluno(a) {aluno.Nome}");
                Console.WriteLine("Digite a Nota A do aluno: ");
                string notaAString = Console.ReadLine();
                Console.WriteLine("Digite a Nota B do aluno: ");
                string notaBString = Console.ReadLine();

                bool valorValido = Regex.IsMatch(notaAString, "^[0-9]+$") && Regex.IsMatch(notaBString, "^[0-9]+$");

                if (valorValido)
                {
                    float notaA = float.Parse(notaAString);
                    float notaB = float.Parse(notaBString);
                    List<Aluno> busca = turma.Alunos.FindAll(n => n.Nome.Contains(aluno.Nome));
                    turma.LancarNotas(busca[0], notaA, notaB);
                }
                else
                {
                    Console.WriteLine("Valores inválidos");
                }
            }
        }

    }
}
