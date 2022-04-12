using System;
using System.Collections.Generic;
using System.Text;

namespace Pensao
{
    class Hospede
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Hospede(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
