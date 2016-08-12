using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class OperatorParameterWrapper : AbstractWrapper<IParameter>
    {
        public OperatorParameterWrapper(IParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitOperatorParameter<TAttributeGroup, TTypeReference>(
            IOperatorParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Value = new OperatorParameter()
            {
                Attributes = parameter.Attributes.ToAttributeListUsingWrapper(),
                Name = parameter.Name,
                ParameterType = new TypeReferenceWrapper(parameter.ParameterType).Value
            };
        }
    }
}
