using System;


namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int ValorSegundo = int.Parse(Console.ReadLine());
            
            int ValorMin = ValorSegundo / 60;
            int ValorHora = ValorMin / 60;
            ValorSegundo = ValorSegundo - ValorMin * 60;
            ValorMin = ValorMin % 60;
            
            
            
            Console.WriteLine(ValorHora+":"+ValorMin+":"+ValorSegundo);



        }
    }
}