using System;



namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int Idade = int.Parse(Console.ReadLine());
            int Ano = Idade / 365;
            int Mes = Idade % 365;
            Mes = Mes / 30;
            int Dia = (Idade % 365) % 30;
            Console.WriteLine((Ano)+" ano(s)");
            Console.WriteLine((Mes)+" mes(es)");
            Console.WriteLine((Dia)+" dia(s)");

        }
    }
}