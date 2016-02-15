using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class IndexerParameterFactory : AbstractFactory<IParameter, IndexerParameter>
    {
        public IndexerParameterFactory(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitIndexerParameter<TAttributeGroup, TTypeReference>(
            IIndexerParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new IndexerParameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingFactory(),
                Modifier = parameter.Modifier,
                Name = parameter.Name,
                ParameterType = new TypeReferenceFactory(parameter.ParameterType).Value
            };
        }
    }
}
