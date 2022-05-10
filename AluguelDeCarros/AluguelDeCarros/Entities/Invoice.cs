using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelDeCarros.Entities
{
    class Invoice
    {
        public double ValorLiquido { get; set; }
        public double Imposto { get; set; }

        public Invoice() { }
        public Invoice(double valorLiquido, double imposto)
        {
            ValorLiquido = valorLiquido;
            Imposto = imposto;
        }

        public double PagamentoTotal
        {
            get { return ValorLiquido + Imposto; }
        }

        public override string ToString()
        {
            return "valor Líquido: "
                + ValorLiquido.ToString("F2")
                + "\nImposto: "
                + Imposto.ToString("F2")
                + "\nValor total: "
                + PagamentoTotal.ToString("F2");
        }
    }
}
