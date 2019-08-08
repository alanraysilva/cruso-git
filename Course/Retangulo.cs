using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Largura) + (Altura + Altura);
        }

        public double Diagonal()
        {
            double c = Math.Pow(Altura, 2) + Math.Pow(Largura, 2);
            return Math.Sqrt(c);
        }
    }
}
/*
 *         static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Altura = " + ret.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
 */
