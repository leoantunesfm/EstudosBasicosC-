using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixacaoInterface.Entities
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<ContratoParcela> Parcelas = new List<ContratoParcela>();

        public Contrato()
        {
        }

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
        }

        public void AddParcelas(ContratoParcela parcela)
        {
            Parcelas.Add(parcela);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Resumo do contrato:");
            sb.Append(Numero + " - " + Data.ToString("d") + " - Valor: $" + ValorTotal.ToString("F2"));
            sb.AppendLine();
            sb.AppendLine("Parcelas: ");
            foreach (ContratoParcela parcela in Parcelas)
            {
                sb.AppendLine(parcela.Data.ToString("d") + " - $" + parcela.Valor.ToString("F2"));
            }

            return sb.ToString();
        }

    }
}
