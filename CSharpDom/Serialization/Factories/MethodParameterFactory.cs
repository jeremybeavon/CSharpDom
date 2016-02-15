using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class MethodParameterFactory : AbstractFactory<IParameter, MethodParameter>
    {
        public MethodParameterFactory(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitMethodParameter<TAttributeGroup, TTypeReference>(
            IMethodParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new MethodParameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingFactory(),
                Modifier = parameter.Modifier,
                Name = parameter.Name,
                ParameterType = new TypeReferenceFactory(parameter.ParameterType).Value
            };
        }
    }
}
