using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Mono.Cecil.Internal.Hiding
{
    internal static class ReturnTypeSignature
    {
        public static readonly ITypeReferenceWithMonoCecil Default =
            TypeReferenceWithMonoCecilFactory.CreateReference(typeof(object));
    }
}
