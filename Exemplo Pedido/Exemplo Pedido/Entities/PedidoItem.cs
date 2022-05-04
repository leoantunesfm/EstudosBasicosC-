using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Pedido.Entities
{
    class PedidoItem
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        #region Construtores

        public PedidoItem()
        {
        }
        public PedidoItem(int quantidade, Produto produto)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = produto.Preco;
        }

        #endregion

        public double SubTotal()
        {
            return Quantidade * Preco;
        }
        public override string ToString()
        {
            return Produto.Nome
                + ", $"
                + Preco.ToString("F2")
                + ", Quantidade: "
                + Quantidade
                + " - Sub Total: $"
                + SubTotal().ToString("F2");
        }
    }
}
