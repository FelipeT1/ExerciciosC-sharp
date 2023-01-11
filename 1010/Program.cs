using System;
using System.Globalization;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string InformacaoPeca;
            InformacaoPeca = Console.ReadLine();
            string[] vetor = InformacaoPeca.Split(' ');
            double Quantidade = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double Preco = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            double Total = Preco*Quantidade;
            string InformacaoPeca2;
            InformacaoPeca2 = Console.ReadLine();
            string[] vetor2 = InformacaoPeca2.Split(' ');
            double Quantidade2 = double.Parse(vetor2[1], CultureInfo.InvariantCulture);
            double Preco2 = double.Parse(vetor2[2], CultureInfo.InvariantCulture);
            double Total2 = Total + (Quantidade2 * Preco2);
            Console.WriteLine("VALOR A PAGAR: R$ " + Total2.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}