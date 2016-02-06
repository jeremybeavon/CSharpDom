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
                GetAccessor = new AccessorFactory(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceFactory(indexer.IndexerType).Value,
                InheritanceModifier = indexer.InheritanceModifier,
                Parameters = indexer.Parameters.ToParameterListUsingFactory(),
                SetAccessor = new AccessorFactory(indexer.SetAccessor).Value,
                Visibility = indexer.Visibility
            };
        }
    }
}
