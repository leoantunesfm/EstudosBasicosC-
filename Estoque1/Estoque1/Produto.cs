using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades. Total: $ "
                + VlTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
