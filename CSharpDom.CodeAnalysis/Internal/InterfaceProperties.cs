using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class InterfaceProperties
    {
        public InterfaceProperties(IBasicTypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            List<InterfaceIndexerWithCodeAnalysis> indexers = new List<InterfaceIndexerWithCodeAnalysis>();
            List<InterfacePropertyWithCodeAnalysis> properties = new List<InterfacePropertyWithCodeAnalysis>();
            foreach (PropertyDefinition property in type.Properties)
            {
                if (property.Parameters.Any())
                {
                    indexers.Add(new InterfaceIndexerWithCodeAnalysis(declaringType, property));
                }
                else
                {
                    properties.Add(new InterfacePropertyWithCodeAnalysis(declaringType, property));
                }
            }
            
            IndexersWithCodeAnalysis = indexers;
            PropertiesWithCodeAnalysis = properties;
        }

        public IReadOnlyCollection<InterfaceIndexerWithCodeAnalysis> IndexersWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<InterfacePropertyWithCodeAnalysis> PropertiesWithCodeAnalysis { get; private set; }
    }
}
