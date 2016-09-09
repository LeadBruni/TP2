using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Fachada
    {
        Punto punto1 = new Punto(0, 0);
        Punto punto2 = new Punto(0, 0);
        Punto punto3 = new Punto(0, 0);
        double radio;

        Circulo fCirculo;
        Triangulo fTriangulo;
        


        public double AreaCirculo (double radio)
        {
            fCirculo = new Circulo(radio);
            return fCirculo.Area;
        }

    }
}
