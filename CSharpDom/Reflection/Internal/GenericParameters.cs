using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class GenericParameters
    {
        public GenericParameters(Type type, MemberInfo member)
        {
            GenericParametersWithReflection = type.GetGenericArguments()
                .Select(parameter => new GenericParameterWithReflection(parameter, member))
                .ToList();
        }

        public IReadOnlyList<GenericParameterWithReflection> GenericParametersWithReflection { get; private set; }
    }
}
