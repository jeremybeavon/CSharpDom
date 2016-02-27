using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class Parameters<TParameter>
    {
        public Parameters(MethodBase method, Func<ParameterWithMonoCecil, TParameter> parameterFactory)
        {
            Initialize(method.GetParameters(), parameterFactory);
        }

        public Parameters(PropertyInfo indexer, Func<ParameterWithMonoCecil, TParameter> parameterFactory)
        {
            Initialize(indexer.GetIndexParameters(), parameterFactory);
        }

        public IReadOnlyList<TParameter> ParametersWithMonoCecil { get; private set; }

        private void Initialize(IEnumerable<ParameterInfo> parameters, Func<ParameterWithMonoCecil, TParameter> parameterFactory)
        {
            ParametersWithMonoCecil = parameters
                .Select(parameter => parameterFactory(new ParameterWithMonoCecil(parameter)))
                .ToList();
        }
    }
}
