using System;
using Exemplo_Pedido.Entities;
using Exemplo_Pedido.Entities.Enums;

namespace Exemplo_Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nomeCliente, email, dataNascimento);

            Console.WriteLine();
            Console.WriteLine("Entre com os dados do pedido: ");
            Console.Write("Status: ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.Write("Quantos itens terá esse pedido? ");
            int qtItens = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtItens; i++)
            {
                Console.WriteLine($"Entre com os dados do {i}º item:");
                Console.Write("Nome: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int quantiadade = int.Parse(Console.ReadLine());

                Produto produto = new Produto(nomeProduto, preco);

                PedidoItem item = new PedidoItem(quantiadade, produto);

                pedido.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine(pedido.ToString());       
            
        }
    }
}
