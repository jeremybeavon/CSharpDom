using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Parameters
    {
        public Parameters(MethodBase method)
        {
            Initialize(method.GetParameters());
        }

        public Parameters(PropertyInfo indexer)
        {
            Initialize(indexer.GetIndexParameters());
        }

        public IReadOnlyList<ParameterWithReflection> ParametersWithReflection { get; private set; }

        private void Initialize(IEnumerable<ParameterInfo> parameters)
        {
            ParametersWithReflection = parameters.Select(parameter => new ParameterWithReflection(parameter)).ToList();
        }
    }
}
