using System;
using System.Globalization;

namespace Cambio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double valorCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorAPagar = ConversorMoeda.ValorAPagar(valorCompra, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + valorAPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
