using System;
using ExemploComposicao.Entities;
using ExemploComposicao.Entities.Enums;

namespace ExemploComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do departamento: ");
            string nomeDept = Console.ReadLine();
            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nível (Junior, Pleno ou Senior): ");
            NivelSenioridade nivel = Enum.Parse<NivelSenioridade>(Console.ReadLine());
            Console.Write("Salário Base: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Departamento departamento = new Departamento(nomeDept);

            Trabalhador trabalhador = new Trabalhador(nome, nivel, salarioBase, departamento);

            Console.Write("Quantos contratos serão cadastrados para esse trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do #{i} contrato:");
                Console.Write("Data(DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                Contrato contrato = new Contrato(data, valorPorHora, horas);

                trabalhador.AddContrato(contrato);
            }

            Console.WriteLine();

            Console.Write("Entre com um mês e um ano para calcular o recebimento(MM/YYYY)");
            string periodo = Console.ReadLine();
            int mes = int.Parse(periodo.Substring(0, 2));
            int ano = int.Parse(periodo.Substring(3));

            Console.WriteLine();
            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Recebimento em " + periodo + ": " + trabalhador.TotalRecebido(ano, mes).ToString("F2"));





        }
    }
}
