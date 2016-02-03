using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class InterfaceProperties
    {
        public InterfaceProperties(IBasicTypeWithReflection declaringType, Type type)
        {
            List<InterfaceIndexerWithReflection> indexers = new List<InterfaceIndexerWithReflection>();
            List<InterfacePropertyWithReflection> properties = new List<InterfacePropertyWithReflection>();
            foreach (PropertyInfo property in type.GetAllProperties())
            {
                if (property.GetIndexParameters().Any())
                {
                    indexers.Add(new InterfaceIndexerWithReflection(declaringType, property));
                }
                else
                {
                    properties.Add(new InterfacePropertyWithReflection(declaringType, property));
                }
            }
            
            IndexersWithReflection = indexers;
            PropertiesWithReflection = properties;
        }

        public IReadOnlyCollection<InterfaceIndexerWithReflection> IndexersWithReflection { get; private set; }

        public IReadOnlyCollection<InterfacePropertyWithReflection> PropertiesWithReflection { get; private set; }
    }
}
