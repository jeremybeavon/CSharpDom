using System;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class PropertyCollection<TProperty, TIndexer, TType>
        where TType : ITypeWithCodeAnalysis
    {
        private readonly Lazy<Properties<TProperty, TIndexer, TType>> properties;

        public PropertyCollection(Func<Properties<TProperty, TIndexer, TType>> properties)
        {
            this.properties = new Lazy<Properties<TProperty, TIndexer, TType>>(properties);
        }

        public Properties<TProperty, TIndexer, TType> Indexers
        {
            get { return properties.Value; }
        }

        public Properties<TProperty, TIndexer, TType> Properties
        {
            get { return properties.Value; }
        }
    }
}
