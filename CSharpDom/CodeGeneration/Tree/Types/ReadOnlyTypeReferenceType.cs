using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public enum ReadOnlyTypeReferenceType
    {
        Class,
        Delegate,
        Enum,
        Interface,
        GenericParameter,
        Struct,
        Reflection,
        Unspecified
    }
}
