using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Polimorfismo.Entities
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }
        
        public ProdutoUsado() { }

        public ProdutoUsado(string nome, double preco, DateTime data) : base (nome, preco)
        {
            DataFabricacao = data;
        }

        public override string EtiquetaPreco()
        {
            return Nome
                + " (Usado), $"
                + Preco.ToString("F2")
                +$" (Data de fabricação: {DataFabricacao})";
        }
    }
}
