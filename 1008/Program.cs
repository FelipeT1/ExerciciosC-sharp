using System;
using System.Globalization;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroFuncionario;
            int HorasTrabalhadas;
            double ValorHora;
            double Salario;

            NumeroFuncionario = int.Parse(Console.ReadLine());
            HorasTrabalhadas = int.Parse(Console.ReadLine());
            ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Salario = (ValorHora * HorasTrabalhadas);
            Console.WriteLine("NUMBER = "+NumeroFuncionario);
            Console.WriteLine("SALARY = U$ "+Salario.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}