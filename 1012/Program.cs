using System;
using System.Globalization;


namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            string Valores;
            Valores = Console.ReadLine();
            string[] V = Valores.Split(' ');
            double A = double.Parse(V[0], CultureInfo.InvariantCulture);
            double B = double.Parse(V[1], CultureInfo.InvariantCulture);
            double C = double.Parse(V[2], CultureInfo.InvariantCulture);
            double AreaT = A*C/2.0;
            double AreaC = C*C*3.14159;
            double AreaTra = (A+B)*C/2.0;
            double AreaQ = B*B;
            double AreaR = A*B;
            Console.WriteLine("TRIANGULO: "+AreaT.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + AreaC.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + AreaTra.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + AreaQ.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + AreaR.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}