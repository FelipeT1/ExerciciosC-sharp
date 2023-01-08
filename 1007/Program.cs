using System;

namespace _1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int Valor1, Valor2, Valor3, Valor4;
            int Diferenca;
            Valor1 = int.Parse(Console.ReadLine());
            Valor2 = int.Parse(Console.ReadLine());
            Valor3 = int.Parse(Console.ReadLine());
            Valor4 = int.Parse(Console.ReadLine());
            Diferenca = (Valor1*Valor2)-(Valor3*Valor4);
            Console.WriteLine("DIFERENCA = " + Diferenca);
        }
    }
}