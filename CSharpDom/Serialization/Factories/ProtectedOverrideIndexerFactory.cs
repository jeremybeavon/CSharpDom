using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ProtectedOverrideIndexerFactory : AbstractFactory<IProtectedOverrideIndexer, ProtectedOverrideIndexer>
    {
        public ProtectedOverrideIndexerFactory(IProtectedOverrideIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitProtectedOverrideIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IProtectedOverrideIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new ProtectedOverrideIndexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new SealedClassAccessorFactory(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceFactory(indexer.IndexerType).Value,
                IsInternal = indexer.IsInternal,
                IsSealed = indexer.IsSealed,
                Parameters = indexer.Parameters.ToParameterListUsingFactory(),
                SetAccessor = new SealedClassAccessorFactory(indexer.GetAccessor).Value
            };
        }
    }
}
