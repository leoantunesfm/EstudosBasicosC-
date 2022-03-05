using System;
using System.Globalization;

namespace Estoque1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double preco;
            int quantidade;

            Console.WriteLine("Entre com os dados do primeiro produto:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

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
