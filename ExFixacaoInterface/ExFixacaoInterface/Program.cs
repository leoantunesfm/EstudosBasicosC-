using System;
using ExFixacaoInterface.Entities;
using ExFixacaoInterface.Services;

namespace ExFixacaoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do contrato:");
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor: ");
            double valor = double.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor);

            Console.Write("Informe a quantidade de meses para parcelamento: ");
            int meses = int.Parse(Console.ReadLine());

            ContratoService contratoService = new ContratoService(new PayPalService());
            contratoService.ProcessaContrato(contrato, meses);

            Console.WriteLine();
            Console.WriteLine(contrato);
        }
    }
}
