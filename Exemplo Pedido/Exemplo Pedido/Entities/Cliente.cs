﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Pedido.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            return Nome
                + " ("
                + DataNascimento.ToString("d")
                + ") - "
                + Email;
        }
    }
}
