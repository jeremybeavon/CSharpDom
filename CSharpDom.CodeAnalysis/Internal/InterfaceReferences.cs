using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class InterfaceReferences
    {
        public InterfaceReferences(AssemblyWithCodeAnalysis assembly, TypeDefinition type)
        {
            InterfaceReferencesWithCodeAnalysis = type.Interfaces
                .Select(interfaceType => new InterfaceReferenceWithCodeAnalysis(assembly, interfaceType))
                .ToList();
        }

        public IReadOnlyList<InterfaceReferenceWithCodeAnalysis> InterfaceReferencesWithCodeAnalysis { get; private set; }
    }
}
