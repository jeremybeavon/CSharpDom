using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class OperatorOverloadWithSymbols : AbstractSymbolNode<IOperatorOverloadWithSymbols>
    {
        private readonly IOperatorOverloadWithSymbols operatorOverload;

        public OperatorOverloadWithSymbols(IOperatorOverloadWithSymbols operatorOverload)
            : base(operatorOverload)
        {
            this.operatorOverload = operatorOverload;
        }
        
        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(operatorOverload.DeclaringType); }
        }
        
        public IMethodSymbol Symbol
        {
            get { return operatorOverload.Symbol; }
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            operatorOverload.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
