using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassIndexerFactory : AbstractFactory<IClassIndexer, ClassIndexer>
    {
        public ClassIndexerFactory(IClassIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new ClassIndexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new ClassAccessorFactory(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceFactory(indexer.IndexerType).Value,
                InheritanceModifier = indexer.InheritanceModifier,
                Parameters = indexer.Parameters.ToList(parameter => new IndexerParameterFactory(parameter).Value),
                SetAccessor = new ClassAccessorFactory(indexer.SetAccessor).Value,
                Visibility = indexer.Visibility
            };
        }
    }
}
