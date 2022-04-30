using System;
using ExemploEnumPedido.Entities;
using ExemploEnumPedido.Entities.Enums;

namespace ExemploEnumPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                NumeroPedido = 123,
                DataEmissao = DateTime.Now,
                Status = StatusPedido.PagamentoPendente
            };

            Console.WriteLine(pedido);
        }
    }
}
