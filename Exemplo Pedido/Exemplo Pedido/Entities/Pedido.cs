using System;
using System.Collections.Generic;
using System.Text;
using Exemplo_Pedido.Entities.Enums;

namespace Exemplo_Pedido.Entities
{
    class Pedido
    {
        public DateTime DataEmissao { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoItem> Itens { get; set; } = new List<PedidoItem>();

        public Pedido()
        {
        }
        public Pedido(DateTime dataEmissao, StatusPedido status, Cliente cliente)
        {
            DataEmissao = dataEmissao;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(PedidoItem item)
        {
            Itens.Add(item);
        }
        public void RemoveItem(PedidoItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double soma = 0.0;

            foreach(PedidoItem item in Itens)
            {
                soma += item.SubTotal();
            }

            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Resumo do pedido:");
            sb.Append("Data de emissão: ");
            sb.AppendLine(DataEmissao.ToString("G"));
            sb.Append("Status do pedido: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Cliente: ");
            sb.AppendLine(Cliente.ToString());
            sb.AppendLine("Itens:");
            foreach(PedidoItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Valor Total: $");
            sb.AppendLine(Total().ToString("F2"));

            return sb.ToString();

        }
    }
}
