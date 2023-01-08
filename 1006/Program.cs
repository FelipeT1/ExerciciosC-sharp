using System;
using System.Globalization;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor1;
            double Valor2;
            double Valor3;
            double Media;

            Valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Media = ((Valor1 * 2.0) + (Valor2 * 3.0) + (Valor3 * 5.0)) / 10.0;
            Console.WriteLine("MEDIA = " + Media.ToString("F1", CultureInfo.InvariantCulture));

        }

    }
}