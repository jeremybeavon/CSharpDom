using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Properties<TProperty, TIndexer, TType>
        where TType : ITypeWithReflection
    {
        public Properties(
            TType declaringType,
            IPropertyFactory<TProperty, TIndexer, TType> propertyFactory,
            ISet<MethodInfo> interfaceMethods)
        {
            List<TIndexer> indexers = new List<TIndexer>();
            List<TProperty> properties = new List<TProperty>();
            List<AbstractIndexerWithReflection> abstractIndexers = new List<AbstractIndexerWithReflection>();
            List<AbstractPropertyWithReflection> abstractProperties = new List<AbstractPropertyWithReflection>();
            List<ExplicitInterfaceIndexerWithReflection> explicitInterfaceIndexers = new List<ExplicitInterfaceIndexerWithReflection>();
            List<ExplicitInterfacePropertyWithReflection> explicitInterfaceProperties = new List<ExplicitInterfacePropertyWithReflection>();
            foreach (PropertyInfo property in declaringType.Type.GetAllProperties())
            {
                MethodInfo method = property.Method();
                if (property.GetIndexParameters().Any())
                {
                    if (interfaceMethods.Contains(method))
                    {
                        explicitInterfaceIndexers.Add(new ExplicitInterfaceIndexerWithReflection(declaringType, property));
                    }
                    else if (method.IsAbstract)
                    {
                        abstractIndexers.Add(new AbstractIndexerWithReflection(declaringType, property));
                    }
                    else
                    {
                        indexers.Add(propertyFactory.CreateIndexer(declaringType, property));
                    }
                }
                else if (interfaceMethods.Contains(method))
                {
                    explicitInterfaceProperties.Add(new ExplicitInterfacePropertyWithReflection(declaringType, property));
                }
                else if (method.IsAbstract)
                {
                    abstractProperties.Add(new AbstractPropertyWithReflection(declaringType, property));
                }
                else
                {
                    properties.Add(propertyFactory.CreateProperty(declaringType, property));
                }
            }

            ExplicitInterfaceIndexersWithReflection = explicitInterfaceIndexers;
            ExplicitInterfacePropertiesWithReflection = explicitInterfaceProperties;
            AbstractIndexersWithReflection = abstractIndexers;
            AbstractPropertiesWithReflection = abstractProperties;
            IndexersWithReflection = indexers;
            PropertiesWithReflection = properties;
        }

        public IReadOnlyCollection<TIndexer> IndexersWithReflection { get; private set; }

        public IReadOnlyCollection<TProperty> PropertiesWithReflection { get; private set; }

        public IReadOnlyCollection<AbstractIndexerWithReflection> AbstractIndexersWithReflection { get; private set; }

        public IReadOnlyCollection<AbstractPropertyWithReflection> AbstractPropertiesWithReflection { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceIndexerWithReflection> ExplicitInterfaceIndexersWithReflection { get; private set; }

        public IReadOnlyCollection<ExplicitInterfacePropertyWithReflection> ExplicitInterfacePropertiesWithReflection { get; private set; }
    }
}
