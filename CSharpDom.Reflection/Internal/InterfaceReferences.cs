using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class InterfaceReferences
    {
        public InterfaceReferences(Type type)
        {
            InterfaceReferencesWithReflection = type.GetInterfaces()
                .Select(interfaceType => new InterfaceReferenceWithReflection(interfaceType))
                .ToList();
        }

        public IReadOnlyList<InterfaceReferenceWithReflection> InterfaceReferencesWithReflection { get; private set; }
    }
}
