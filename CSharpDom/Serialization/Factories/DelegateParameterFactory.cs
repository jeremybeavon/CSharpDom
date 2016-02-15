using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class DelegateParameterFactory : AbstractFactory<IParameter, DelegateParameter>
    {
        public DelegateParameterFactory(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitDelegateParameter<TAttributeGroup, TTypeReference>(
            IDelegateParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new DelegateParameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingFactory(),
                Modifier = parameter.Modifier,
                Name = parameter.Name,
                ParameterType = new TypeReferenceFactory(parameter.ParameterType).Value
            };
        }
    }
}
