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
                this.estado = (estado == "" || estado == "Desligada") ? "Ligada" : this.estado; 
        }
        public void Apagar()
        {
                this.estado = (estado == "Ligada") ? "Desligada" : this.estado; 
        }

        public string MostrarEstado() => this.estado; 
        
    }
}
