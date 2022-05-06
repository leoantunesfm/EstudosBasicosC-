namespace Ex_ClassesMetodosAbstratos.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double DespesasMedicas { get; set; }
        public PessoaFisica() { }

        public PessoaFisica(string nome, double receitaAnual, double despesasMedicas) : base (nome, receitaAnual)
        {
            DespesasMedicas = despesasMedicas;
        }

        public override double Imposto()
        {
            if (ReceitaAnual < 20000.0)
            {
                return ReceitaAnual * 0.15 - (DespesasMedicas * 0.5);
            }
            else
            {
                return ReceitaAnual * 0.25 - (DespesasMedicas * 0.5);
            }
        }


    }
}
