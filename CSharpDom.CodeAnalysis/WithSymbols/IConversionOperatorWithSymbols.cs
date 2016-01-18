using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IConversionOperatorWithSymbols : 
        IConversionOperator<ITypeWithSymbols>,
        IHasSymbol<IMethodSymbol>,
        IHasSyntax<IConversionOperatorSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
