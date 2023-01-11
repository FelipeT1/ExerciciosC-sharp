using System;
using System.Globalization;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int Velocidade;
            int Tempo;
            double Litros;
            Velocidade = int.Parse(Console.ReadLine());
            Tempo = int.Parse(Console.ReadLine());
            Litros = ((double)(Velocidade * Tempo)/12);

            Console.WriteLine(Litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}