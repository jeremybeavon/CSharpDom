using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom
{
    internal interface ITypeName
    {
        string Name { get; }

        int GenericParameterCount { get; }

        string NameWithGenericParameterCount { get; }
    }
}
