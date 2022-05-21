using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Exemplo_lambda.Entidades;

namespace Exemplo_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho completo do arquivo: ");
            string path = Console.ReadLine();

            List<Funcionario> funcionarios = new List<Funcionario>();

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] dados = sr.ReadLine().Split(',');
                    string nome = dados[0];
                    string email = dados[1];
                    double salario = double.Parse(dados[2], CultureInfo.InvariantCulture);

                    funcionarios.Add(new Funcionario(nome, email, salario));
                }
            }

            Console.Write("Entre com o salário: ");
            double salarioInformado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("E-mails das pessoas com salário maior que " + salarioInformado.ToString("F2", CultureInfo.InvariantCulture) + ": ");

            var emails = funcionarios.Where(f => f.Salario > salarioInformado).OrderBy(f => f.Email).Select(f => f.Email);

            foreach(string email in emails)
            {
                Console.WriteLine(email);
            }

            var soma = funcionarios.Where(f => f.Nome[0] == 'M').Select(f => f.Salario).Sum();

            Console.Write("Soma dos salario das pessoas com nome iniciado em M: " + soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
