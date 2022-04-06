using System;
using System.Globalization;
namespace ContaBancaria
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int nrConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular: ");
            string nmTitular = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());

            double valor = 0.0;

            if (opcao.Equals('s') || opcao.Equals('S'))
            {
                Console.WriteLine();
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            ContaPadrao conta = new ContaPadrao(nrConta, nmTitular, valor);

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor do depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);

            Console.WriteLine();
            Console.WriteLine("Dados da conta bancária atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor do saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);

            Console.WriteLine();
            Console.WriteLine("Dados da conta bancária atualizados:");
            Console.WriteLine(conta);

            Console.ReadLine();
        }
    }
}
