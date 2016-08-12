using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ConstructorParameterWrapper : AbstractWrapper<IParameter>
    {
        public ConstructorParameterWrapper(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitConstructorParameter<TAttributeGroup, TTypeReference>(
            IConstructorParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new ConstructorParameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingWrapper(),
                Modifier = parameter.Modifier,
                Name = parameter.Name,
                ParameterType = new TypeReferenceWrapper(parameter.ParameterType).Value
            };
        }
    }
}
