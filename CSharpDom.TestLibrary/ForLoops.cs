using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.TestLibrary
{
    public class ForLoops
    {
        public static int Sum(int max)
        {
            int total = 0;
            for (int current = 1; current <= max; current++)
            {
                total += current;
            }

            return total;
        }
    }
}
