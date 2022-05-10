using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelDeCarros.Services
{
    class ImpostoBrasilService : IImpostoService
    {
        public double Imposto(double baseCalculo)
        {
            if(baseCalculo <= 100.0)
            {
                return baseCalculo * 0.2;
            }
            else
            {
                return baseCalculo * 0.15;
            }
        }
    }
}
