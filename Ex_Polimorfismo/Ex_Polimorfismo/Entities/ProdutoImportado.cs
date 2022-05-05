using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Polimorfismo.Entities
{
    class ProdutoImportado : Produto
    {
        public double TaxaImportacao { get; set; }

        public ProdutoImportado() { }

        public ProdutoImportado(string nome, double preco, double taxaImportacao) : base (nome, preco)
        {
            TaxaImportacao = taxaImportacao;
        }

        public override string EtiquetaPreco()
        {
            return Nome
                + ", $"
                + PrecoTotal().ToString("F2") 
                + $" (Taxa de importação: ${TaxaImportacao.ToString("F2")})";
        }

        public double PrecoTotal()
        {
            return Preco + TaxaImportacao;
        }
    }
}
