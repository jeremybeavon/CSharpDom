using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Attributes
    {
        public Attributes(MemberInfo member)
        {
            Initialize(CustomAttributeData.GetCustomAttributes(member));
        }

        public Attributes(ParameterInfo parameter)
        {
            Initialize(CustomAttributeData.GetCustomAttributes(parameter));
        }

        public IReadOnlyCollection<AttributeWithReflection> AttributesWithReflection { get; private set; }
        
        private void Initialize(IEnumerable<CustomAttributeData> attributes)
        {
            AttributesWithReflection = attributes.Select(attribute => new AttributeWithReflection(attribute)).ToList();
        }
    }
}
