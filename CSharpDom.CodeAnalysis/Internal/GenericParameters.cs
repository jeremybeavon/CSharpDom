using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class GenericParameters
    {
        public GenericParameters(AssemblyWithCodeAnalysis assembly, TypeReference type)
        {
            GenericInstanceType genericType = type as GenericInstanceType;
            if (genericType == null)
            {
                GenericParametersWithCodeAnalysis = new List<GenericParameterWithCodeAnalysis>();
            }
            else
            {
                GenericParametersWithCodeAnalysis = genericType.GenericArguments
                    .Select(parameter => new GenericParameterWithCodeAnalysis(assembly, parameter))
                    .ToList();
            }
        }

        public IReadOnlyList<GenericParameterWithCodeAnalysis> GenericParametersWithCodeAnalysis { get; private set; }
    }
}
