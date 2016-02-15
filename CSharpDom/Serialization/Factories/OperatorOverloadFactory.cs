using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class OperatorOverloadFactory : AbstractFactory<IOperatorOverload, OperatorOverload>
    {
        public OperatorOverloadFactory(IOperatorOverload operatorOverload)
            : base(operatorOverload)
        {
        }

        public override void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
        {
            Value = new OperatorOverload()
            {
                Attributes = operatorOverload.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(operatorOverload.Body).Value,
                OperatorType = operatorOverload.OperatorType,
                Parameters = operatorOverload.Parameters.ToList(parameter => new OperatorParameterFactory(parameter).Value),
                ReturnType = new TypeReferenceFactory(operatorOverload.ReturnType).Value
            };
        }
    }
}
