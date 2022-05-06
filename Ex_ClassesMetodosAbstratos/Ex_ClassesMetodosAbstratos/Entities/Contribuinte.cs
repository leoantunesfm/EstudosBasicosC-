namespace Ex_ClassesMetodosAbstratos.Entities
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double ReceitaAnual { get; set; }

        public Contribuinte() { }

        protected Contribuinte(string nome, double receitaAnual)
        {
            Nome = nome;
            ReceitaAnual = receitaAnual;
        }

        public abstract double Imposto();
    }
}
