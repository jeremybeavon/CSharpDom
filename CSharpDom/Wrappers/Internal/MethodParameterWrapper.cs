using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class MethodParameterWrapper : AbstractWrapper<IParameter>
    {
        public MethodParameterWrapper(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitMethodParameter<TAttributeGroup, TTypeReference>(
            IMethodParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new MethodParameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingWrapper(),
                Modifier = parameter.Modifier,
                Name = parameter.Name,
                ParameterType = new TypeReferenceWrapper(parameter.ParameterType).Value
            };
        }
    }
}
