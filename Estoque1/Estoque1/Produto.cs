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

        public Produto (string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double VlTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void SomaEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void SubtraiEstoque(int quantidade)
        {
            Quantidade -= quantidade;
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
