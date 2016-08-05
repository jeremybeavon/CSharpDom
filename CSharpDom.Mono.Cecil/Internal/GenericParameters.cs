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
            GenericInstanceType genericType = type as GenericInstanceType;
            if (genericType == null)
            {
                GenericParametersWithMonoCecil = new List<GenericParameterWithMonoCecil>();
            }
            else
            {
                GenericParametersWithMonoCecil = genericType.GenericArguments
                    .Select(parameter => new GenericParameterWithMonoCecil(assembly, parameter))
                    .ToList();
            }
        }

        public IReadOnlyList<GenericParameterWithMonoCecil> GenericParametersWithMonoCecil { get; private set; }
    }
}
