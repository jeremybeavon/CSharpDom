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
                GenericParametersWithMonoCecil = new List<ITypeReferenceWithMonoCecil>();
            }
            else
            {
                GenericParametersWithMonoCecil = genericType.GenericArguments
                    .Select(parameter => TypeReferenceWithMonoCecilFactory.CreateReference(assembly, parameter))
                    .ToList();
            }
        }

        public IReadOnlyList<ITypeReferenceWithMonoCecil> GenericParametersWithMonoCecil { get; private set; }
    }
}
