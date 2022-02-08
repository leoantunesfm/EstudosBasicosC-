using System;
using System.Globalization;

namespace Estoque1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do primeiro produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos para adicionar no estoque: ");
            int qt = int.Parse(Console.ReadLine());

            p.SomaEstoque(qt);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos para remover no estoque: ");
            qt = int.Parse(Console.ReadLine());

            p.SubtraiEstoque(qt);

            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
