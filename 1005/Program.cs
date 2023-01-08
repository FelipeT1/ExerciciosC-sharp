
using System;
using System.Globalization;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor1;
            double Valor2;
            double Media;

            Valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Media = ((Valor1*3.5) + (Valor2*7.5)) / 11.0;
            Console.WriteLine("MEDIA = " + Media.ToString("F5", CultureInfo.InvariantCulture));
            
        }

    }
}
