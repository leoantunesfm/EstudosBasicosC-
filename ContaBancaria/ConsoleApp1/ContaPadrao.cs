using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    class ContaPadrao
    {
        public int NrConta { get; private set; }
        public string NmTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaPadrao(int nrConta, string nmTitular)
        {
            NrConta = nrConta;
            NmTitular = nmTitular;
        }

        public ContaPadrao (int nrConta, string nmTitular, double valor) : this (nrConta, nmTitular)
        {
            Deposito(valor);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        } 

        public void Saque(double valor)
        {
            Saldo -= (valor + 5.0);
        }

        public override string ToString()
        {
            return
                "Conta: "
                + NrConta
                + ", Titular: "
                + NmTitular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
