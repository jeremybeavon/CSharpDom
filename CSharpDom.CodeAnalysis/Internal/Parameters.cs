using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class Parameters<TParameter>
    {
        public Parameters(
            AssemblyWithCodeAnalysis assembly,
            MethodDefinition method,
            Func<ParameterWithCodeAnalysis, TParameter> parameterFactory)
        {
            Initialize(assembly, method, method.Parameters, parameterFactory);
        }

        public Parameters(
            AssemblyWithCodeAnalysis assembly,
            PropertyDefinition indexer,
            Func<ParameterWithCodeAnalysis, TParameter> parameterFactory)
        {
            Initialize(assembly, indexer, indexer.Parameters, parameterFactory);
        }

        public IReadOnlyList<TParameter> ParametersWithCodeAnalysis { get; private set; }

        private void Initialize(
            AssemblyWithCodeAnalysis assembly,
            MemberReference member,
            IEnumerable<ParameterDefinition> parameters,
            Func<ParameterWithCodeAnalysis, TParameter> parameterFactory)
        {
            ParametersWithCodeAnalysis = parameters
                .Select(parameter => parameterFactory(new ParameterWithCodeAnalysis(assembly, parameter, member)))
                .ToList();
        }
    }
}
