using Mono.Cecil;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class GenericParameterDeclarations
    {
        public GenericParameterDeclarations(AssemblyWithMonoCecil assembly, TypeDefinition type)
        {
            Initialize(assembly, type.GenericParameters);
        }

        public GenericParameterDeclarations(AssemblyWithMonoCecil assembly, MethodDefinition method)
        {
            Initialize(assembly, method.GenericParameters);
        }

        public IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameterDeclarationsWithMonoCecil { get; private set; }

        private void Initialize(AssemblyWithMonoCecil assembly, IEnumerable<GenericParameter> types)
        {
            GenericParameterDeclarationsWithMonoCecil = types
                .Select(parameter => new GenericParameterDeclarationWithMonoCecil(assembly, parameter))
                .ToList();
        }
    }
}
