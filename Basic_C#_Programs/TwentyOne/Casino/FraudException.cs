using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        public FraudException()
            : base() { } // This is an example of Exception constructor inheritance.
        public FraudException(string message)
            : base(message) { }
    }
}
