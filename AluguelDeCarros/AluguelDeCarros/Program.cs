using System;
using System.Globalization;
using AluguelDeCarros.Entities;
using AluguelDeCarros.Services;

namespace AluguelDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel: ");
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Retirada: ");
            DateTime retirada = DateTime.ParseExact(Console.ReadLine(),"g",CultureInfo.CurrentCulture);
            Console.Write("Devolução: ");
            DateTime devolucao = DateTime.ParseExact(Console.ReadLine(), "g", CultureInfo.CurrentCulture);

            Console.Write("Preço por hora: ");
            double precoHora = double.Parse(Console.ReadLine());
            Console.Write("Preço por dia: ");
            double precoDia = double.Parse(Console.ReadLine());

            AluguelVeiculo aluguelVeiculo = new AluguelVeiculo(retirada, devolucao, new Veiculo(modelo));

            AluguelService aluguelService = new AluguelService(precoHora, precoDia);

            aluguelService.ProcessaInvoice(aluguelVeiculo);

            Console.WriteLine("Nota de pagamento:");
            Console.WriteLine(aluguelVeiculo.Invoice);


        }
    }
}
