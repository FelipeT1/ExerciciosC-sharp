using System;
using System.Globalization;


namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(valores1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(valores1[1], CultureInfo.InvariantCulture);
            string[] valores2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(valores2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(valores2[1], CultureInfo.InvariantCulture);
            double Distancia = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Distancia = Math.Pow(Distancia,1.0/2.0);
            Console.WriteLine(Distancia.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}