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
            if(x > 0 && y > 0) { Quadrante = "1º"; }
            if(x > 0 && y < 0) { Quadrante = "2º"; }
            if(x < 0 && y < 0) { Quadrante = "3º"; }
            if(x < 0 && y > 0) { Quadrante = "4º"; }
        }

        public string GetQuadrante()
        {
            VerificarQuadrante();
            return Quadrante;
        }
    }
}
