﻿namespace AluguelDeCarros.Entities
{
    class Veiculo
    {
        public string Modelo { get; set; }

        public Veiculo() { }

        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }
    }
}
