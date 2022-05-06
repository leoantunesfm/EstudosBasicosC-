using System;
using System.Collections.Generic;
using Ex_ClassesMetodosAbstratos.Entities;

namespace Ex_ClassesMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número de contribuintes: ");
            int qtdContribuintes = int.Parse(Console.ReadLine());

            List<Contribuinte> contribuintes = new List<Contribuinte>();

            for (int i = 1; i <= qtdContribuintes; i++)
            {
                Console.WriteLine($"Dados do {i}º contribuinte:");
                Console.Write("Pessoa física ou jurídica (f/j)? ");
                char pessoaTipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Receita anual: ");
                double receitaAnual = double.Parse(Console.ReadLine());

                if (pessoaTipo == 'f' || pessoaTipo == 'F')
                {
                    Console.Write("Despesas médicas: ");
                    double despesasMedicas = double.Parse(Console.ReadLine());

                    contribuintes.Add(new PessoaFisica(nome, receitaAnual, despesasMedicas));
                }
                else
                {
                    Console.Write("Quantidade de funcionários: ");
                    int qtdFuncionarios = int.Parse(Console.ReadLine());

                    contribuintes.Add(new PessoaJuridica(nome, receitaAnual, qtdFuncionarios));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Contribuintes: ");

            double totalImpostos = 0.0;

            foreach(Contribuinte contribuinte in contribuintes)
            {
                double imposto = contribuinte.Imposto();
                Console.WriteLine(contribuinte.Nome + ": $ " + imposto.ToString("F2"));
                totalImpostos += imposto;
            }

            Console.WriteLine();
            Console.WriteLine("Total de arrecadação: $ " + totalImpostos.ToString("F2"));

        }
    }
}
