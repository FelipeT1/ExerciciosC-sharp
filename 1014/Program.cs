using System;
using System.Globalization;


namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int DistanciaPercorrida;
            double CombustivelGasto;
            double Consumo;
            DistanciaPercorrida = int.Parse(Console.ReadLine());
            CombustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Consumo = DistanciaPercorrida / CombustivelGasto;
            Console.WriteLine(Consumo.ToString("F3", CultureInfo.InvariantCulture)+" km/l");





        }
    }
}