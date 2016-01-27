using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Properties
    {
        public Properties(IBasicTypeWithReflection declaringType, Type type)
        {
            List<IndexerWithReflection> indexers = new List<IndexerWithReflection>();
            List<PropertyWithReflection> properties = new List<PropertyWithReflection>();
            foreach (PropertyInfo property in type.GetAllProperties())
            {
                if (property.GetIndexParameters().Any())
                {
                    indexers.Add(new IndexerWithReflection(declaringType, property));
                }
                else
                {
                    properties.Add(new PropertyWithReflection(declaringType, property));
                }
            }

            IndexersWithReflection = indexers;
            PropertiesWithReflection = properties;
        }

        public IReadOnlyCollection<IndexerWithReflection> IndexersWithReflection { get; private set; }

        public IReadOnlyCollection<PropertyWithReflection> PropertiesWithReflection { get; private set; }
    }
}
