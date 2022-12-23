using System;

namespace Desafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoMenu = "0";
            Agenda agenda = new Agenda();

            while (opcaoMenu != "5")
            {
                Console.WriteLine("Selecione uma opção:\nDigite 1 para listar todos os contatos\nDigite 2 para filtrar os contatos a serem listados\nDigite 3 para adicionar um contato\nDigite 4 para remover um contato\nDigite 5 para sair");
                opcaoMenu = Console.ReadLine();

                switch (opcaoMenu)
                {
                    case "1":
                        agenda.ListarContatos();
                        break;
                    case "2":
                        Console.WriteLine("Digite qual será o filtro para pesquisa...");
                        string filtro = Console.ReadLine();
                        agenda.ListarContatos(filtro);
                        break;
                    case "3":
                        Console.WriteLine("Digite o nome do contato que será adicionado...");
                        string nomeContato = Console.ReadLine();
                        Console.WriteLine("Agora digite o número do contato");
                        string numeroContato = Console.ReadLine();

                        Contato contato = new Contato(nomeContato, numeroContato);
                        agenda.ListaDeContatos.Add(contato);
                        break;
                    case "4":
                        Console.WriteLine("Digite o nome do contato que será excluido...");
                        string nomeContatoExcluido = Console.ReadLine();
                        agenda.EscolherRemoverContato(nomeContatoExcluido);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
