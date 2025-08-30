using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    internal class Disciplina
    {
        string Professor;
        string Materia;
        double Nota1Bi;
        double Nota2Bi;
        public Disciplina(string professor, string materia) 
        {
            this.Professor = professor;
            this.Materia = materia;
            Nota1Bi = 0.0;
            Nota2Bi = 0.0;
        }
        public double GetNota1Bi() => Nota1Bi;
        public double GetNota2Bi() => Nota2Bi;



        public void SetNota1Bi(double nota1bi) 
        {
            if (Nota1Bi >= 0 && Nota1Bi <= 10.0)
            {
                this.Nota1Bi = nota1bi;
            }
        }
        public void SetNota2Bi(double nota2bi)
        {
            if (Nota2Bi >= 0 && Nota2Bi <= 10.0)
            {
                this.Nota2Bi = nota2bi;
            }
        }

        public double Media() => ((Nota1Bi + Nota2Bi) / 2);

        public string Conceito() 
        {
            string conceito = "";

            if (Media()>6) 
            {
                conceito = "Aprovado";
            }
            else 
            {
                conceito = "Reprovado";
            }
                return conceito; 
        }


    }
}
