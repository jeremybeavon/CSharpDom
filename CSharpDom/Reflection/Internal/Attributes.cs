using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Attributes
    {
        public Attributes(MemberInfo member, params Type[] excludedTypes)
        {
            Initialize(CustomAttributeData.GetCustomAttributes(member), excludedTypes);
        }

        public Attributes(ParameterInfo parameter, params Type[] excludedTypes)
        {
            Initialize(CustomAttributeData.GetCustomAttributes(parameter), excludedTypes);
        }

        public IReadOnlyCollection<AttributeWithReflection> AttributesWithReflection { get; private set; }
        
        private void Initialize(IEnumerable<CustomAttributeData> attributes, params Type[] excludedTypes)
        {
            AttributesWithReflection = attributes
                .Where(attribute => !excludedTypes.Contains(attribute.Constructor.DeclaringType))
                .Select(attribute => new AttributeWithReflection(attribute))
                .ToList();
        }
    }
}
