using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Circulo
    {
        private double iRadio;
        private Punto iCentro;

        public Circulo(double pRadio): this(null, pRadio) { }
        public Circulo (Punto Centro, double Radio)
        {
            this.iRadio = Radio;
            this.iCentro = Centro;
        }
        public Circulo (double pX,double pY,double Radio)
        {
            this.iCentro = new Punto(pX, pY);
            this.iRadio = Radio;
        }

        public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }
        public double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }
        public double Area
        { get { return ((Math.Pow(Radio, 2)) * Math.PI); } }
        
        public double Perimetro
        { get { return (Math.PI*Radio*2); } }

    }
}
