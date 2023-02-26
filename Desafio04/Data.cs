using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04
{
    public class Data
    {
        public int Dia { get; set; } = -1;
        public int Mes { get; set; } = -1;
        public int Ano { get; set; } = -1;

        public Data(int dia, int mes, int ano)
        {
            bool dataValida = ValidarData(dia, mes, ano);
            if (dataValida)
            {
                this.Dia = dia;
                this.Mes = mes;
                this.Ano = ano;
            }
        }

        public Data(string dataFormatada)
        {
            int dia = Convert.ToInt32(dataFormatada[0].ToString() + dataFormatada[1].ToString());
            int mes = Convert.ToInt32(dataFormatada[3].ToString() + dataFormatada[4].ToString());
            int ano = Convert.ToInt32(dataFormatada[6].ToString() + dataFormatada[7].ToString());

            bool dataValida = ValidarData(dia, mes, ano);
            if (dataValida)
            {
                this.Dia = dia;
                this.Mes = mes;
                this.Ano = ano;
            }
        }

        public bool ValidarData(int dia, int mes, int ano)
        {
            if (dia < 1 || dia > 31 || mes < 1 || mes > 12 || ano < 1500 || ano > 2500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
