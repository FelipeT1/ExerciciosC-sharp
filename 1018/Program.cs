using System;


namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int Valor = int.Parse(Console.ReadLine());
            int Ori = Valor;
            int Temp;

            Valor = Valor / 100;
            int _100 = Valor;
            Temp = (Ori - (Valor * 100));

            Valor = Temp / 50;
            int _50 = Valor;
            Temp = (Temp - (Valor * 50));

            Valor = Temp / 20;
            int _20 = Valor;
            Temp = (Temp - (Valor * 20));

            Valor = Temp / 10;
            int _10 = Valor;
            Temp = (Temp - (Valor * 10));

            Valor = Temp / 5;   
            int _5 = Valor;
            Temp = (Temp - (Valor * 5));

            Valor = Temp / 2;
            int _2 = Valor;
            Temp = (Temp - (Valor * 2));

            Valor = Temp / 1;
            int _1 = Valor;

            Console.WriteLine(Ori);
            Console.WriteLine(_100 + " nota(s) de R$ 100,00");
            Console.WriteLine(_50 + " nota(s) de R$ 50,00");
            Console.WriteLine(_20 + " nota(s) de R$ 20,00");
            Console.WriteLine(_10 + " nota(s) de R$ 10,00");
            Console.WriteLine(_5 + " nota(s) de R$ 5,00");
            Console.WriteLine(_2 + " nota(s) de R$ 2,00");
            Console.WriteLine(_1 + " nota(s) de R$ 1,00");



        }
    }
}