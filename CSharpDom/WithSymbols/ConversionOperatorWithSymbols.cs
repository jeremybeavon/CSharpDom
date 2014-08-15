using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class ConversionOperatorWithSymbols : AbstractSymbolNode<IConversionOperatorWithSymbols>
    {
        private readonly IConversionOperatorWithSymbols conversionOperator;

        public ConversionOperatorWithSymbols(IConversionOperatorWithSymbols conversionOperator)
            : base(conversionOperator)
        {
            this.conversionOperator = conversionOperator;
        }

        public ConversionOperatorDeclarationSyntax Declaration
        {
            get { return conversionOperator.Declaration; }
        }

        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(conversionOperator.DeclaringType); }
        }

        public int EndLine
        {
            get { return conversionOperator.EndLine; }
        }

        public int StartLine
        {
            get { return conversionOperator.StartLine; }
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
