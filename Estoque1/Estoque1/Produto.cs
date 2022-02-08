using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque1
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double VlTotalEstoque()
        {
            return Preco * Quantidade;
        }
    }
}
