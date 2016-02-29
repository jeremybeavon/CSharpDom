using Mono.Cecil;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class InterfaceProperties
    {
        public InterfaceProperties(IBasicTypeWithMonoCecil declaringType, TypeDefinition type)
        {
            List<InterfaceIndexerWithMonoCecil> indexers = new List<InterfaceIndexerWithMonoCecil>();
            List<InterfacePropertyWithMonoCecil> properties = new List<InterfacePropertyWithMonoCecil>();
            foreach (PropertyDefinition property in type.Properties)
            {
                if (property.Parameters.Any())
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
