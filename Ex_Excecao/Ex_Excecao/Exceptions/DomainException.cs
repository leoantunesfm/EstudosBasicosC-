using System;

namespace Ex_Excecao.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mensage) : base(mensage)
        {

        }
    }
}
