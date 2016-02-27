using System;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class PropertyCollection<TProperty, TIndexer, TType>
        where TType : ITypeWithMonoCecil
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
