using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class Properties<TProperty, TIndexer, TType>
        where TType : ITypeWithMonoCecil
    {
        public Properties(
            TType declaringType,
            IPropertyFactory<TProperty, TIndexer, TType> propertyFactory)
        {
            List<TIndexer> indexers = new List<TIndexer>();
            List<TProperty> properties = new List<TProperty>();
            List<AbstractIndexerWithMonoCecil> abstractIndexers = new List<AbstractIndexerWithMonoCecil>();
            List<AbstractPropertyWithMonoCecil> abstractProperties = new List<AbstractPropertyWithMonoCecil>();
            List<ExplicitInterfaceIndexerWithMonoCecil> explicitInterfaceIndexers = new List<ExplicitInterfaceIndexerWithMonoCecil>();
            List<ExplicitInterfacePropertyWithMonoCecil> explicitInterfaceProperties = new List<ExplicitInterfacePropertyWithMonoCecil>();
            foreach (PropertyDefinition property in declaringType.TypeDefinition.Properties)
            {
                MethodDefinition method = property.Method();
                //TypeDefinition interfaceType;
                if (property.Parameters.Any())
                {
                    /*if (interfaceMethods.TryGetValue(method, out interfaceType))
                    {
                        explicitInterfaceIndexers.Add(new ExplicitInterfaceIndexerWithMonoCecil(declaringType, interfaceType, property));
                    }
                    else*/ if (method.IsAbstract)
                    {
                        abstractIndexers.Add(new AbstractIndexerWithMonoCecil(declaringType, property));
                    }
                    else
                    {
                        indexers.Add(propertyFactory.CreateIndexer(declaringType, property));
                    }
                }
                /*else if (interfaceMethods.TryGetValue(method, out interfaceType))
                {
                    explicitInterfaceProperties.Add(new ExplicitInterfacePropertyWithMonoCecil(declaringType, interfaceType, property));
                }*/
                else if (method.IsAbstract)
                {
                    abstractProperties.Add(new AbstractPropertyWithMonoCecil(declaringType, property));
                }
                else
                {
                    properties.Add(propertyFactory.CreateProperty(declaringType, property));
                }
            }

            ExplicitInterfaceIndexersWithMonoCecil = explicitInterfaceIndexers;
            ExplicitInterfacePropertiesWithMonoCecil = explicitInterfaceProperties;
            AbstractIndexersWithMonoCecil = abstractIndexers;
            AbstractPropertiesWithMonoCecil = abstractProperties;
            IndexersWithMonoCecil = indexers;
            PropertiesWithMonoCecil = properties;
        }

        public IReadOnlyCollection<TIndexer> IndexersWithMonoCecil { get; private set; }

        public IReadOnlyCollection<TProperty> PropertiesWithMonoCecil { get; private set; }

        public IReadOnlyCollection<AbstractIndexerWithMonoCecil> AbstractIndexersWithMonoCecil { get; private set; }

        public IReadOnlyCollection<AbstractPropertyWithMonoCecil> AbstractPropertiesWithMonoCecil { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceIndexerWithMonoCecil> ExplicitInterfaceIndexersWithMonoCecil { get; private set; }

        public IReadOnlyCollection<ExplicitInterfacePropertyWithMonoCecil> ExplicitInterfacePropertiesWithMonoCecil { get; private set; }
    }
}
