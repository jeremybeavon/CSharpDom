using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ConstructorParameterFactory : AbstractFactory<IParameter, ConstructorParameter>
    {
        public ConstructorParameterFactory(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitConstructorParameter<TAttributeGroup, TTypeReference>(
            IConstructorParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new ConstructorParameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingFactory(),
                Modifier = parameter.Modifier,
                Name = parameter.Name,
                ParameterType = new TypeReferenceFactory(parameter.ParameterType).Value
            };
        }
    }
}
