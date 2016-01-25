using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class GenericParameterDeclarations
    {
        public GenericParameterDeclarations(Type type)
        {
            GenericParameterDeclarationsWithReflection = type.GetGenericArguments()
                .Select(parameter => new GenericParameterDeclarationWithReflection(parameter))
                .ToList();
        }

        public IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameterDeclarationsWithReflection { get; private set; }
    }
}
