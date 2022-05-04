using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Pedido.Entities.Enums
{
    enum StatusPedido : int
    {
        PagamentoPendente,
        Processando,
        Enviado,
        Entregue
    }
}
