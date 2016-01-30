using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ParameterFactory : AbstractFactory<IParameter, Parameter>
    {
        public ParameterFactory(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitParameter<TAttributeGroup, TTypeReference>(IParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new Parameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingFactory(),
                Modifier = parameter.Modifier,
                Name = parameter.Name,
                ParameterType = new TypeReferenceFactory(parameter.ParameterType).Value
            };
        }
    }
}
