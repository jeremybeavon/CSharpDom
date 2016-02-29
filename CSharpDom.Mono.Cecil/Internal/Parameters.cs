using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class Parameters<TParameter>
    {
        public Parameters(
            AssemblyWithMonoCecil assembly,
            MethodDefinition method,
            Func<ParameterWithMonoCecil, TParameter> parameterFactory)
        {
            Initialize(assembly, method.Parameters, parameterFactory);
        }

        public Parameters(
            AssemblyWithMonoCecil assembly,
            PropertyDefinition indexer,
            Func<ParameterWithMonoCecil, TParameter> parameterFactory)
        {
            Initialize(assembly, indexer.Parameters, parameterFactory);
        }

        public IReadOnlyList<TParameter> ParametersWithMonoCecil { get; private set; }

        private void Initialize(
            AssemblyWithMonoCecil assembly,
            IEnumerable<ParameterDefinition> parameters,
            Func<ParameterWithMonoCecil, TParameter> parameterFactory)
        {
            ParametersWithMonoCecil = parameters
                .Select(parameter => parameterFactory(new ParameterWithMonoCecil(assembly, parameter)))
                .ToList();
        }
    }
}
