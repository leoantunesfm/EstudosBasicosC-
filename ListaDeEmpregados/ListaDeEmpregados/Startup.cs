using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaDeEmpregados
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos empregados você deseja registrar? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            List<Empregado> empregados = new List<Empregado>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Empregado nº {i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                empregados.Add(new Empregado(id, nome, salario));
            }

            Console.Write("Informe o ID do funcionário que deseja aumentar o salário: ");
            int idBusca = int.Parse(Console.ReadLine());

            Empregado empregadoParaAumento = empregados.Find(x => x.Id == idBusca);

            if (empregadoParaAumento != null)
            {
                Console.Write("Entre com o percentual para o aumento: ");
                double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                empregadoParaAumento.AumentoSalario(percentual);
            }
            else
            {
                Console.WriteLine("Id de funcionário não encontrado.");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada:");

            foreach(Empregado emp in empregados)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
