using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    public class Coordenadas
    {
        string Quadrante = "1º";
        double x = 0;
        double y = 0;

        public void SetX(double _x) => x = _x;
        public void SetY(double _y) => y = _y; 

        public void VerificarQuadrante()
        {
            Quadrante = (x > 0 && y > 0) ? "1º" : Quadrante;
            Quadrante = (x > 0 && y < 0) ? "2º" : Quadrante;
            Quadrante = (x < 0 && y < 0) ? "3º" : Quadrante; 
            Quadrante = (x < 0 && y > 0) ? "4º" : Quadrante; 
        }

        public string GetQuadrante()
        {
            VerificarQuadrante();
            return Quadrante;
        }
    }
}
