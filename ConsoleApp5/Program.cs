using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1V,y1V;
            int x2V,y2V;
            int x3V,y3V;
            int x4V,y4V;

            //VALORES A INGRESAR POR CONSOLA
            Console.WriteLine("Ingrese la primera coordenada del punto V1 (?, y): ");
            x1V = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda coordenada del punto V1 (x, ?): ");
            y1V = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la primera coordenada del punto V2 (?, y): ");
            x2V = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda coordenada del punto V2 (x, ?): ");
            y2V = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la primera coordenada del punto V3 (?, y): ");
            x3V = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda coordenada del punto V3 (x, ?): ");
            y3V = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la primera coordenada del punto V4 (?, y): ");
            x4V = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda coordenada del punto V4 (x, ?): ");
            y4V = int.Parse(Console.ReadLine());


            Rectangulo rectangulo = new Rectangulo();

            Vertice v1 = new Vertice
            {
                x = x1V,
                y = y1V
            };

            Vertice v2 = new Vertice
            {
                x = x2V,
                y = y2V
            };

            Vertice v3 = new Vertice
            {
                x = x3V,
                y = y3V
            };

            Vertice v4 = new Vertice
            {
                x = x4V,
                y = y4V
            };

            rectangulo.v1 = v1;
            rectangulo.v2 = v2;
            rectangulo.v3 = v3;
            rectangulo.v4 = v4;

            Console.WriteLine("El area del rectangulo es: " + rectangulo.GetArea());
            Console.WriteLine("El perimetro del rectangulo es: " + rectangulo.GetPerimetro());

        }
    }
}
