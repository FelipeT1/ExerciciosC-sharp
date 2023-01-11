using System;
using System.Globalization;


namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pi = 3.14159;
            double Raio;
            double Volume;
            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Volume = (Pi * Raio * Raio * Raio) * (4.0 / 3.0);
            Console.WriteLine("VOLUME = " + Volume.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}