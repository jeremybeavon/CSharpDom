using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface ICanBeGeneric
    {
        bool IsGeneric { get; }

        int GenericParameterCount { get; }
    }
}
