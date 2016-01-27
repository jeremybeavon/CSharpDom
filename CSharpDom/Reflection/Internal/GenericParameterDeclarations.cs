using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
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

        public IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameterDeclarationsWithReflection { get; private set; }

        private void Initialize(IEnumerable<Type> types)
        {
            GenericParameterDeclarationsWithReflection = types
                .Select(parameter => new GenericParameterDeclarationWithReflection(parameter))
                .ToList();
        }
    }
}
