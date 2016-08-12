using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ExtensionParameterWrapper : AbstractWrapper<IParameter>
    {
        public ExtensionParameterWrapper(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitExtensionParameter<TAttributeGroup, TTypeReference>(
            IExtensionParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new ExtensionParameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingWrapper(),
                Name = parameter.Name,
                ParameterType = new TypeReferenceWrapper(parameter.ParameterType).Value
            };
        }
    }
}
