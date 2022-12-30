using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        public string CodigoConta { get; set; }
        public List<string> ListaDeTranacacoes { get; set; } = new List<string>();
        public double Saldo { 
            get { return Saldo; } 
            set 
            {
                if (value > 0)
                {
                    this.Saldo = value;
                }
                else
                {
                    Console.WriteLine("O valor a ser definido não pode ser menor que 0");
                }
            } 
        }

        public ContaBancaria(string titular, string codigoConta)
        {
            Titular = titular;
            CodigoConta = codigoConta;
            Saldo = 0;
        }


        public void Depositar(double valor)
        {
            this.Saldo += valor;
            ListaDeTranacacoes.Add($"Foi depositado {valor}R$ na conta");
        }

        public void Sacar(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
                ListaDeTranacacoes.Add($"Foi sacado {valor}R$ da conta");
            }
            else
            {
                Console.WriteLine("Não foi possível fazer o saque");
            }
        }

        public void ConsultarTransacoes()
        {
            foreach(string transacao in ListaDeTranacacoes)
            {
                Console.WriteLine(transacao);
            }
        }
    }
}
