using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class OperatorOverloadWrapper : AbstractWrapper<IOperatorOverload>
    {
        public OperatorOverloadWrapper(IOperatorOverload operatorOverload)
            : base(operatorOverload)
        {
        }

        public override void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
        {
            Value = new OperatorOverload()
            {
                Attributes = operatorOverload.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(operatorOverload.Body).Value,
                OperatorType = operatorOverload.OperatorType,
                Parameters = operatorOverload.Parameters.ToList(parameter => new OperatorParameterWrapper(parameter).Value),
                ReturnType = new TypeReferenceWrapper(operatorOverload.ReturnType).Value
            };
        }
    }
}
