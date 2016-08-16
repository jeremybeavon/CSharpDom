using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class GenericParameterDeclarations
    {
        public GenericParameterDeclarations(AssemblyWithCodeAnalysis assembly, TypeDefinition type)
        {
            Initialize(assembly, type.GenericParameters);
        }

        public GenericParameterDeclarations(AssemblyWithCodeAnalysis assembly, MethodDefinition method)
        {
            Initialize(assembly, method.GenericParameters);
        }

        public IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameterDeclarationsWithCodeAnalysis { get; private set; }

        private void Initialize(AssemblyWithCodeAnalysis assembly, IEnumerable<GenericParameter> types)
        {
            GenericParameterDeclarationsWithCodeAnalysis = types
                .Select(parameter => new GenericParameterDeclarationWithCodeAnalysis(assembly, parameter))
                .ToList();
        }
    }
}
