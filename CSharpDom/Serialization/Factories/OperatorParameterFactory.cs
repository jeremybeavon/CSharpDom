using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class OperatorParameterFactory : AbstractFactory<IParameter, OperatorParameter>
    {
        public OperatorParameterFactory(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitOperatorParameter<TAttributeGroup, TTypeReference>(
            IOperatorParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new OperatorParameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingFactory(),
                Name = parameter.Name,
                ParameterType = new TypeReferenceFactory(parameter.ParameterType).Value
            };
        }
    }
}
