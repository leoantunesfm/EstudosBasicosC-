namespace Ex_ClassesMetodosAbstratos.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int QtdFuncionarios { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(string nome, double receitaAnual, int qtdFuncionarios) : base(nome, receitaAnual)
        {
            QtdFuncionarios = qtdFuncionarios;
        }

        public override double Imposto()
        {
            if(QtdFuncionarios > 10)
            {
                return ReceitaAnual * 0.14;
            }
            else
            {
                return ReceitaAnual * 0.16;
            }
        }
    }
}
