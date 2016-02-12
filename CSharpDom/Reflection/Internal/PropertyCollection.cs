using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class PropertyCollection<TProperty, TIndexer, TType> :
        VisitableNotSupported<IGenericVisitor>,
        IPropertyCollection,
        IIndexerCollection
        where TType : ITypeWithReflection
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
