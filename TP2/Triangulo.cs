using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Triangulo
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        public Triangulo(Punto pPunto1,Punto pPunto2,Punto pPunto3)
        { this.iPunto1 = pPunto1;this.iPunto2 = pPunto2;this.iPunto3 = pPunto3; }

        public Punto Punto1 {get { return this.iPunto1; } }
        public Punto Punto2 { get { return this.iPunto2; } }
        public Punto Punto3 {get { return this.iPunto3; } }

        public double Perimetro
        {
            get
            {
                return (iPunto1.CalcularDistanciaDesde(this.iPunto1) +
                    iPunto2.CalcularDistanciaDesde(this.iPunto3) +
                    iPunto3.CalcularDistanciaDesde(this.iPunto1));
            }
        }
        public double Semiperimetro { get { return (Perimetro / 2); } }
 

        public double Area
        {
            get { return (Math.Sqrt(Semiperimetro * (Semiperimetro - iPunto1.CalcularDistanciaDesde(this.iPunto2)) * 
                (Semiperimetro - iPunto1.CalcularDistanciaDesde(this.iPunto3)) * 
                (Semiperimetro - iPunto2.CalcularDistanciaDesde(this.iPunto3)))); }
        }
    }
}
