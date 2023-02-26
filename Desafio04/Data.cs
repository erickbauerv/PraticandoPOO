using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04
{
    public class Data
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public DateTime DataCompleta { get; set; }

        public Data(int dia, int mes, int ano)
        {
            DefinirData(dia, mes, ano);
            this.DataCompleta = new DateTime(this.Ano, this.Mes, this.Dia);
        }

        public Data(string dataFormatada)
        {
            int dia = Convert.ToInt32(dataFormatada[0].ToString() + dataFormatada[1].ToString());
            int mes = Convert.ToInt32(dataFormatada[3].ToString() + dataFormatada[4].ToString());
            int ano = Convert.ToInt32(dataFormatada[6].ToString() + dataFormatada[7].ToString() + dataFormatada[8].ToString() +dataFormatada[9].ToString());

            DefinirData(dia, mes, ano);
            this.DataCompleta = new DateTime(this.Ano, this.Mes, this.Dia);
        }

        public bool ValidarData(int dia, int mes, int ano)
        {
            if (dia < 1 || dia > 31 || mes < 1 || mes > 12 || ano < 1500 || ano > 2500)
            {
                return false;
            }

            return true;
        }

        public void DefinirData(int dia, int mes, int ano)
        {
            bool dataValida = ValidarData(dia, mes, ano);
            if (dataValida)
            {
                this.Dia = dia;
                this.Mes = mes;
                this.Ano = ano;
            }
            else
            {
                this.Dia = -1;
                this.Mes = -1;
                this.Ano = -1;
            }
        }

        public void AdicionarDias(int quantidadeDeDias)
        {
            if (this.Dia == 31)
            {
                if (this.Mes == 12)
                {
                    this.Mes = 0;
                    this.Ano += 1;
                }

                this.Dia = 0;
                this.Mes += 1;
            }

            this.Dia += quantidadeDeDias;
            this.DataCompleta = new DateTime(this.Ano, this.Mes, this.Dia);
        }

        public void ImprimirData()
        {
            Console.WriteLine($"Dia {this.DataCompleta.Day}, do {this.DataCompleta.Month} de {this.DataCompleta.Year}");
        }

        public void ImprimirDataFormatada()
        {

            Console.WriteLine($"{this.DataCompleta.Date}");
        }
    }
}
