using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Parameters<TParameter>
    {
        public Parameters(MethodBase method, Func<ParameterWithReflection, TParameter> parameterFactory)
        {
            Initialize(method.GetParameters(), parameterFactory);
        }

        public Parameters(PropertyInfo indexer, Func<ParameterWithReflection, TParameter> parameterFactory)
        {
            Initialize(indexer.GetIndexParameters(), parameterFactory);
        }

        public IReadOnlyList<TParameter> ParametersWithReflection { get; private set; }

        private void Initialize(IEnumerable<ParameterInfo> parameters, Func<ParameterWithReflection, TParameter> parameterFactory)
        {
            ParametersWithReflection = parameters
                .Select(parameter => parameterFactory(new ParameterWithReflection(parameter)))
                .ToList();
        }
    }
}
