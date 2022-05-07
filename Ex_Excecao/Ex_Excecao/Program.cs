using System;
using Ex_Excecao.Entities;
using Ex_Excecao.Exceptions;

namespace Ex_Excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Informe os dados da conta: ");
                Console.Write("Número: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque: ");
                double limite = double.Parse(Console.ReadLine());

                Conta conta = new Conta(numero, nome, saldo, limite);

                Console.WriteLine();
                Console.Write("Entre com o valor para o saque: ");
                double valor = double.Parse(Console.ReadLine());
                conta.Saque(valor);

                Console.WriteLine("Saldo atualizado: " + conta.Saldo.ToString("F2"));
            }
            catch (DomainException exception)
            {
                Console.WriteLine("Erro: " + exception.Message);
            }
        }
    }
}
