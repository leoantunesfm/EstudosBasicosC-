using Ex_Excecao.Exceptions;

namespace Ex_Excecao.Entities
{
    class Conta
    {
        public int NrConta { get; set; }
        public string NomeCliente { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta() { }

        public Conta(int nrConta, string nomeCliente, double saldo, double limiteSaque)
        {
            if (saldo < 0.0)
            {
                throw new DomainException("valor inválido");
            }

            NrConta = nrConta;
            NomeCliente = nomeCliente;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if (valor < 0.0)
            {
                throw new DomainException("valor inválido");
            }
            if (valor > LimiteSaque)
            {
                throw new DomainException("O valor solicitado excede o limite de saque permitido.");
            }
            if (valor > Saldo)
            {
                throw new DomainException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }
    }
}
