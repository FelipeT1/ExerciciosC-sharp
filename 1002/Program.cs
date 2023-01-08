using System;
using System.Globalization;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pi;
            double Raio;
            double Area;

            Pi = 3.14159;
            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Area = (Raio * Raio * Pi);

            Console.WriteLine("A="+Area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}