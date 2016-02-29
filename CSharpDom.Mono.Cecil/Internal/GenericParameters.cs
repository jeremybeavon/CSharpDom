using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class GenericParameters
    {
        public GenericParameters(AssemblyWithMonoCecil assembly, TypeReference type)
        {
            GenericParametersWithMonoCecil = type.GenericParameters
                .Select(parameter => new GenericParameterWithMonoCecil(assembly, parameter))
                .ToList();
        }

        public IReadOnlyList<GenericParameterWithMonoCecil> GenericParametersWithMonoCecil { get; private set; }
    }
}
