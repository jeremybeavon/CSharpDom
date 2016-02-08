using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal.Hiding
{
    internal static class ReturnTypeSignature
    {
        public static readonly ITypeReferenceWithReflection Default =
            TypeReferenceWithReflectionFactory.CreateReference(typeof(object));
    }
}
