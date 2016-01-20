using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeNumberException
{
    public class NegativeNumException1 : Exception
    {
        public NegativeNumException1(string message): base(message)
        {

        }
    }
}
