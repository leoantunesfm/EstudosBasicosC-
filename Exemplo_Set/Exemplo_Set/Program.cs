using System;
using System.Collections.Generic;

namespace Exemplo_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> alunos = new HashSet<int>();
            Console.Write("Quantos alunos do curso A? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                alunos.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos do curso B? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                alunos.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos do curso C? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                alunos.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Total de alunos: " + alunos.Count) ;
        }
    }
}
