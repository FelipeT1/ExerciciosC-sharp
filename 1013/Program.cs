using System;



namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string Valores;
            Valores = Console.ReadLine();
            string[] V = Valores.Split(' ');
            int A = int.Parse(V[0]);
            int B = int.Parse(V[1]);
            int C = int.Parse(V[2]);
            int MaiorAB = (A + B + Math.Abs(A - B)) / 2;
            int MaiorABC = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

            Console.WriteLine(MaiorABC+" eh o maior");





        }
    }
}