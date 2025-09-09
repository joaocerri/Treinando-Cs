using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Data
    {
        private int Dia;
        private int Mes;
        private int Ano;

        public Data()
        {
            Dia = 18;
            Mes = 10;
            Ano = 2006;
        }
        public void Set(int dia, int mes, int ano)
        {
            if(dia>=1 && dia<=31)
            {
                Dia = dia;
            }
            if(mes>=1 && mes<=12)
            {
                Mes = mes;
            }

            if(ano>=1000 && ano<=2025)
            {
                Ano = ano;
            }
        }
        public int GetAno()
        {
            return Ano;
        }

        public int GetMes()
        {
            return Mes;
        }
        public int GetDia()
        {
            return Dia;
        }

        public string DataFormatada()
        {
            return $"{Dia:D2}/{Mes:D2}/{Ano}";
        }

        public string DataExtenso()
        {
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            return $"{Dia} de {meses[Mes - 1]} de {Ano}";
        }
    }
}
