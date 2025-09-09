using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Tempo
    {
        private int horas;
        private int minutos; 
        private int segundos;

        public Tempo()
        {
            horas = 23;
            minutos = 59;
            segundos = 59;
        }
        public Tempo(int TempoHora, int TempoMin, int TempoSeg)
        {
            horas = TempoHora;
            minutos = TempoMin;
            segundos = TempoSeg;
        }
        public void SetHoras(int horas)
        {
            this.horas = (horas >= 0 && horas <= 23) ? horas : this.horas;
        }

        public void SetMinutos(int minutos)
        {
            this.minutos = (minutos >= 0 && minutos <= 59) ? minutos : this.minutos;
        }

        public void SetSegundos(int segundos)
        {
            this.segundos = (segundos >= 0 && segundos <= 59) ? segundos : this.segundos;
        }

        public int GetHoras() => horas;
        public int GetMinutos() => minutos;       
        public int GetSegundos() => segundos;
        public int TotalSegundos() => (horas * 3600) + (minutos * 60) + segundos;       
        public void ImprimirTempoSimples() => Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", horas, minutos, segundos);
        public void ImprimirTempoCompleto() => Console.WriteLine("{0} horas, {1} minutos e {2} segundos", horas, minutos, segundos); 
    }
}
