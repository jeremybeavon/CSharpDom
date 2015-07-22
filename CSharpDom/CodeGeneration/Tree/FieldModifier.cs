using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public enum FieldModifier
    {
        None,
        Const,
        Static,
        ReadOnly,
        StaticReadOnly,
        Volatile,
        StaticVolatile
    }
}
