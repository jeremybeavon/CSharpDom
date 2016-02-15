using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ExtensionParameterFactory : AbstractFactory<IParameter, ExtensionParameter>
    {
        public ExtensionParameterFactory(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitExtensionParameter<TAttributeGroup, TTypeReference>(
            IExtensionParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new ExtensionParameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingFactory(),
                Name = parameter.Name,
                ParameterType = new TypeReferenceFactory(parameter.ParameterType).Value
            };
        }
    }
}
