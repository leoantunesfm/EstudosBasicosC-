using System;
using System.Collections.Generic;
using System.Text;
using ExemploEnumPedido.Entities.Enums;

namespace ExemploEnumPedido.Entities
{
    class Pedido
    {
        public int NumeroPedido { get; set; }
        public DateTime DataEmissao { get; set; }
        public StatusPedido Status { get; set; }

        public override string ToString()
        {
            return NumeroPedido
                + ", "
                + DataEmissao
                + ", "
                + Status;
        }
    }
}
