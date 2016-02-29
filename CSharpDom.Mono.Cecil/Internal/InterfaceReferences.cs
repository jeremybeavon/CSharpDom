using Mono.Cecil;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class InterfaceReferences
    {
        public InterfaceReferences(AssemblyWithMonoCecil assembly, TypeDefinition type)
        {
            InterfaceReferencesWithMonoCecil = type.Interfaces
                .Select(interfaceType => new InterfaceReferenceWithMonoCecil(assembly, interfaceType))
                .ToList();
        }

        public IReadOnlyList<InterfaceReferenceWithMonoCecil> InterfaceReferencesWithMonoCecil { get; private set; }
    }
}
