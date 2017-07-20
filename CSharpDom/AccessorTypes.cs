using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom
{
    [Flags]
    public enum AccessorTypes
    {
        Get = 1,
        Set = 2,
        GetAndSet = 3
    }
}
