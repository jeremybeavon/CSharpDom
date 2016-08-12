using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class DelegateParameterWrapper : AbstractWrapper<IParameter>
    {
        public DelegateParameterWrapper(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitDelegateParameter<TAttributeGroup, TTypeReference>(
            IDelegateParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new DelegateParameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingWrapper(),
                Modifier = parameter.Modifier,
                Name = parameter.Name,
                ParameterType = new TypeReferenceWrapper(parameter.ParameterType).Value
            };
        }
    }
}
