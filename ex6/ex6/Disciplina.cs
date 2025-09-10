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
                this.Nota1Bi = (Nota1Bi >= 0 && Nota1Bi <= 10.0) ? nota1bi : this.Nota1Bi ; 
        }
        public void SetNota2Bi(double nota2bi)
        {
            this.Nota2Bi = (Nota2Bi >= 0 && Nota2Bi <= 10.0) ? nota2bi : this.Nota2Bi;
        }

        public double Media() => ((Nota1Bi + Nota2Bi) / 2);

        public string Conceito() 
        {
            string conceito = ""; 
            
            conceito = (Media() > 6) ? "Aprovado" : "Reprovado";
           
            return conceito;
        }


    }
}
