using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Core.Exceptions
{
    public class SampleEcommerceException : Exception
    {
        public SampleEcommerceException(string message) : base(message)
        {
        }

        public SampleEcommerceException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
