using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class GenericParameterDeclarations
    {
        public GenericParameterDeclarations(Type type)
        {
            Initialize(type.GetGenericArguments());
        }

        public GenericParameterDeclarations(MethodInfo method)
        {
            Initialize(method.GetGenericArguments());
        }

        public IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameterDeclarationsWithMonoCecil { get; private set; }

        private void Initialize(IEnumerable<Type> types)
        {
            GenericParameterDeclarationsWithMonoCecil = types
                .Select(parameter => new GenericParameterDeclarationWithMonoCecil(parameter))
                .ToList();
        }
    }
}
