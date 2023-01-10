using System; 
using System.Globalization;

namespace _1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            double Salario;
            double TotalVenda;
            double Montante;

            Nome = Console.ReadLine();
            Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TotalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Montante = 15 * TotalVenda / 100 + Salario;

            Console.WriteLine("TOTAL = R$ " + Montante.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}