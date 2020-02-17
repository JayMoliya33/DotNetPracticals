using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            String infix = "a+b";
            String postfix;
            infixtoPostfix(ref infix, out postfix);
        }
    }
}
