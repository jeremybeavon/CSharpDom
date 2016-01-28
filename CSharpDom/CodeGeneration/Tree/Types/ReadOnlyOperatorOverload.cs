using CSharpDom.Common;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyOperatorOverload : IOperatorOverload
    {
        private readonly IOperatorOverload operatorOverload;

        public ReadOnlyOperatorOverload(BinaryOperator operatorOverload)
        {
            this.operatorOverload = new ReadOnlyBinaryOperator(operatorOverload);
        }

        public ReadOnlyOperatorOverload(UnaryOperator operatorOverload)
        {
            this.operatorOverload = new ReadOnlyUnaryOperator(operatorOverload);
        }

        public void Accept(IGenericVisitor visitor)
        {
            operatorOverload.Accept(visitor);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            operatorOverload.AcceptChildren(visitor);
        }
    }
}
