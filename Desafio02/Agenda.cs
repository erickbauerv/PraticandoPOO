using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    class Agenda
    {
        public List<Contato> ListaDeContatos { get; set; } = new List<Contato>();

        public Agenda()
        {
            ListaDeContatos = new List<Contato>();
        }

        /// <summary>
        /// Método para listar os contatos de uma agenda.
        /// </summary>
        /// <param name="filtro">Parâmetro para filtrar os contatos que serão listados, caso não seja informado vai listar todos contatos.</param>
        public void ListarContatos(string filtro = null)
        {
            List<Contato> listaDeContatos = this.ListaDeContatos;

            if (filtro != null)
            {
                listaDeContatos = this.ListaDeContatos.FindAll(contato => contato.Nome.StartsWith(filtro));
            }

            if (!listaDeContatos.Any())
            {
                Console.WriteLine("Nenhum contato encontrado.");
                return;
            }

            foreach (Contato contato in listaDeContatos)
            {
                Console.WriteLine($"Nome: {contato.Nome} - Número: {contato.Numero}");
            }
        }

        public void EscolherRemoverContato(string filtro)
        {
            string desejaExcluir;
            Contato contato = this.ListaDeContatos.FirstOrDefault(contato => contato.Nome == filtro);

            Console.WriteLine($"O contato que será removido é o {contato.Nome} do número {contato.Numero}\ntem certeza que deseja excluir? digite 1 para sim e 2 para não...");
            desejaExcluir = Console.ReadLine();
            switch (desejaExcluir)
            {
                case "1":
                    this.ListaDeContatos.Remove(contato);
                    break;
                case "2":
                    Console.WriteLine("O contato não foi excluido");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
