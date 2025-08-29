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
        public void SetHoras(int TempoHoras)
        {
            if (horas >= 0 && horas <= 23)
            {
                horas = TempoHoras;
            }
        }

        public void SetMinutos(int minutos)
        {
            if (minutos >= 0 && minutos <= 59)
            { 
                this.minutos = minutos;
            }
        }

        public void SetSegundos(int segundos)
        {
            if (segundos >= 0 && segundos <= 59)
            {
                this.segundos = segundos;
            }
        }

        public int GetHoras()
        {
            return horas;
        }

        public int GetMinutos()
        {
            return minutos;
        }

        public int GetSegundos()
        {
            return segundos;
        }

        public int TotalSegundos()
        {
            return (horas * 3600) + (minutos * 60) + segundos;
        }

        public void ImprimirTempoSimples()
        {
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", horas, minutos, segundos);
        }

        public void ImprimirTempoCompleto()
        {
            Console.WriteLine("{0} horas, {1} minutos e {2} segundos", horas, minutos, segundos);
        }   
    }
}
