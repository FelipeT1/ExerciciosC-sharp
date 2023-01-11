using System;


namespace _1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int Distancia;
            int Tempo;
            Distancia = int.Parse(Console.ReadLine());
            Tempo = Distancia * 2;
            Console.WriteLine(Tempo+" minutos");
        }
    }
}