using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class InterfaceReferences
    {
        public InterfaceReferences(Type type)
        {
            InterfaceReferencesWithMonoCecil = type.GetInterfaces()
                .Select(interfaceType => new InterfaceReferenceWithMonoCecil(interfaceType))
                .ToList();
        }

        public IReadOnlyList<InterfaceReferenceWithMonoCecil> InterfaceReferencesWithMonoCecil { get; private set; }
    }
}
