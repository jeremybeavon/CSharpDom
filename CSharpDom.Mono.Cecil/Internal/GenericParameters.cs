using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class GenericParameters
    {
        public GenericParameters(Type type)
        {
            GenericParametersWithMonoCecil = type.GetGenericArguments()
                .Select(parameter => new GenericParameterWithMonoCecil(parameter))
                .ToList();
        }

        public IReadOnlyList<GenericParameterWithMonoCecil> GenericParametersWithMonoCecil { get; private set; }
    }
}
