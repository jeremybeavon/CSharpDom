using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class GenericParameters
    {
        public GenericParameters(Type type)
        {
            GenericParametersWithReflection = type.GetGenericArguments()
                .Select(parameter => new GenericParameterWithReflection(parameter))
                .ToList();
        }

        public IReadOnlyList<GenericParameterWithReflection> GenericParametersWithReflection { get; private set; }
    }
}
