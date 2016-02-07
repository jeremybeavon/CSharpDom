using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassIndexerFactory : AbstractFactory<ISealedClassIndexer, SealedClassIndexer>
    {
        public SealedClassIndexerFactory(ISealedClassIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitSealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            ISealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new SealedClassIndexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new SealedClassAccessorFactory(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceFactory(indexer.IndexerType).Value,
                InheritanceModifier = indexer.InheritanceModifier,
                Parameters = indexer.Parameters.ToParameterListUsingFactory(),
                SetAccessor = new SealedClassAccessorFactory(indexer.SetAccessor).Value,
                Visibility = indexer.Visibility
            };
        }
    }
}
