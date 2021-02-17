using System;

namespace SalesWebMvc.Services.Excpetions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {

        }
    }
}
