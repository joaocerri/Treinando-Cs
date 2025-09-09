using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1._2
{
    public class Lampada
    {
        private string estado;
        public Lampada()
        {
            this.estado = "";
        }

        public void Acender()
        {
            if(estado == "" || estado == "Desligada")
            {
                this.estado = "Ligada"; 
            }   
        }
        public void Apagar()
        {
            if(estado == "Ligada")
            {
                this.estado = "Desligada"; 
            }   
        }

        public string MostrarEstado() 
        { 
            return this.estado; 
        }
        
    }
}
