using System;
using System.Collections.Generic;
using System.Text;

namespace LosingMoney
{
    public class NumberException : Exception
    {
        public NumberException(string message) : base(message)
        {

        }
    }
}
