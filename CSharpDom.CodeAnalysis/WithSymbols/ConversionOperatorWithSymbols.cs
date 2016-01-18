using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class ConversionOperatorWithSymbols : AbstractSymbolNode<IConversionOperatorWithSymbols>
    {
        private readonly IConversionOperatorWithSymbols conversionOperator;

        public ConversionOperatorWithSymbols(IConversionOperatorWithSymbols conversionOperator)
            : base(conversionOperator)
        {
            this.conversionOperator = conversionOperator;
        }
        
        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(conversionOperator.DeclaringType); }
        }
        
        public IMethodSymbol Symbol
        {
            get { return conversionOperator.Symbol; }
        }

        public IConversionOperatorWithSymbols AsInterface()
        {
            return conversionOperator;
        }
        
        public override void Accept(SymbolsVisitor visitor)
        {
            conversionOperator.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
