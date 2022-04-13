using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = Conversor.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais é " + result.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
