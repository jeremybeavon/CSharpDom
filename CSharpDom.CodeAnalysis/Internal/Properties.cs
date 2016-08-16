using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class Properties<TProperty, TIndexer, TType>
        where TType : ITypeWithCodeAnalysis
    {
        public Properties(
            TType declaringType,
            IPropertyFactory<TProperty, TIndexer, TType> propertyFactory)
        {
            List<TIndexer> indexers = new List<TIndexer>();
            List<TProperty> properties = new List<TProperty>();
            List<AbstractIndexerWithCodeAnalysis> abstractIndexers = new List<AbstractIndexerWithCodeAnalysis>();
            List<AbstractPropertyWithCodeAnalysis> abstractProperties = new List<AbstractPropertyWithCodeAnalysis>();
            List<ExplicitInterfaceIndexerWithCodeAnalysis> explicitInterfaceIndexers = new List<ExplicitInterfaceIndexerWithCodeAnalysis>();
            List<ExplicitInterfacePropertyWithCodeAnalysis> explicitInterfaceProperties = new List<ExplicitInterfacePropertyWithCodeAnalysis>();
            foreach (PropertyDefinition property in declaringType.TypeDefinition.Properties)
            {
                MethodDefinition method = property.Method();
                if (property.Parameters.Any())
                {
                    if (property.Name.Contains("."))
                    {
                        explicitInterfaceIndexers.Add(new ExplicitInterfaceIndexerWithCodeAnalysis(declaringType, property));
                    }
                    else if (method.IsAbstract)
                    {
                        abstractIndexers.Add(new AbstractIndexerWithCodeAnalysis(declaringType, property));
                    }
                    else
                    {
                        indexers.Add(propertyFactory.CreateIndexer(declaringType, property));
                    }
                }
                else if (property.Name.Contains("."))
                {
                    explicitInterfaceProperties.Add(new ExplicitInterfacePropertyWithCodeAnalysis(declaringType, property));
                }
                else if (method.IsAbstract)
                {
                    abstractProperties.Add(new AbstractPropertyWithCodeAnalysis(declaringType, property));
                }
                else
                {
                    properties.Add(propertyFactory.CreateProperty(declaringType, property));
                }
            }

            ExplicitInterfaceIndexersWithCodeAnalysis = explicitInterfaceIndexers;
            ExplicitInterfacePropertiesWithCodeAnalysis = explicitInterfaceProperties;
            AbstractIndexersWithCodeAnalysis = abstractIndexers;
            AbstractPropertiesWithCodeAnalysis = abstractProperties;
            IndexersWithCodeAnalysis = indexers;
            PropertiesWithCodeAnalysis = properties;
        }

        public IReadOnlyCollection<TIndexer> IndexersWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<TProperty> PropertiesWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<AbstractIndexerWithCodeAnalysis> AbstractIndexersWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<AbstractPropertyWithCodeAnalysis> AbstractPropertiesWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceIndexerWithCodeAnalysis> ExplicitInterfaceIndexersWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfacePropertiesWithCodeAnalysis { get; private set; }
    }
}
