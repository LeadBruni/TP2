using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada Fachada = new Fachada();
            Console.WriteLine("Elija la figura para Trabajar ingresando la opcion deseada: ");
            Console.WriteLine("1-Triangulo  2-Circulo");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Ingrese X del primer Punto: ");
                        double p1X = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese Y del primer Punto: ");
                        double p1y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese X del segundo Punto: ");
                        double p2X = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese Y del segundo Punto: ");
                        double p2y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese X del tercer Punto: ");
                        double p3X = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese Y del tercer Punto: ");
                        double p3y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("el perimetro del triangulo es {0}", Fachada.perimetroTriangulo(p1X, p1y, p2X, p2y, p3X, p3y));
                        Console.WriteLine("el area del triangulo es {0}", Fachada.areaTriangulo(p1X, p1y, p2X, p2y, p3X, p3y));
                        Console.ReadKey();


                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Ingrese X del centro: ");
                        double p1X = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese Y del centro: ");
                        double p1y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el radio: ");
                        double radio = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El area del circulo es"+Fachada.areaCirculo(radio));
                        Console.WriteLine("El perimetro del circulo es "+Fachada.perimetroCirculo(radio));
                        Console.ReadKey();
                        break;
                    }
            }
        }
    }
    }

