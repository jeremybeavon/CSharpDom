using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class IndexerParameterWrapper : AbstractWrapper<IParameter>
    {
        public IndexerParameterWrapper(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitIndexerParameter<TAttributeGroup, TTypeReference>(
            IIndexerParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new IndexerParameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingWrapper(),
                Modifier = parameter.Modifier,
                Name = parameter.Name,
                ParameterType = new TypeReferenceWrapper(parameter.ParameterType).Value
            };
        }
    }
}
