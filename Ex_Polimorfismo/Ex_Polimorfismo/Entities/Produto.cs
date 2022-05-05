using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Polimorfismo.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string EtiquetaPreco()
        {
            return Nome
                + " - $"
                + Preco.ToString("F2");
        }
    }
}
