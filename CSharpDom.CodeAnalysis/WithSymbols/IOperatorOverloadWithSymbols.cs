using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IOperatorOverloadWithSymbols :
        IOperatorOverload<ITypeWithSymbols>,
        IHasSymbol<IMethodSymbol>,
        IHasSyntax<IOperatorOverloadSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
