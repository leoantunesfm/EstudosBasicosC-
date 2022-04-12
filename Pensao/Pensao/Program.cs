using System;

namespace Pensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Hospede[] hospede = new Hospede[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                hospede[quarto] = new Hospede(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (!(hospede[i] == null))
                {
                    Console.WriteLine(i + ": " + hospede[i].Nome + ", " + hospede[i].Email);
                }
            }
        }
    }
}
