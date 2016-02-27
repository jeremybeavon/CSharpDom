using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class InterfaceProperties
    {
        public InterfaceProperties(IBasicTypeWithMonoCecil declaringType, Type type)
        {
            List<InterfaceIndexerWithMonoCecil> indexers = new List<InterfaceIndexerWithMonoCecil>();
            List<InterfacePropertyWithMonoCecil> properties = new List<InterfacePropertyWithMonoCecil>();
            foreach (PropertyInfo property in type.GetAllProperties())
            {
                if (property.GetIndexParameters().Any())
                {
                    indexers.Add(new InterfaceIndexerWithMonoCecil(declaringType, property));
                }
                else
                {
                    properties.Add(new InterfacePropertyWithMonoCecil(declaringType, property));
                }
            }
            
            IndexersWithMonoCecil = indexers;
            PropertiesWithMonoCecil = properties;
        }

        public IReadOnlyCollection<InterfaceIndexerWithMonoCecil> IndexersWithMonoCecil { get; private set; }

        public IReadOnlyCollection<InterfacePropertyWithMonoCecil> PropertiesWithMonoCecil { get; private set; }
    }
}
