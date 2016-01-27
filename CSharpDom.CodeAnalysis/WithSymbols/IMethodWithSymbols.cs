using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IMethodWithSymbols :
        IMethod<IBasicTypeWithSymbols>,
        IHasSymbol<IMethodSymbol>,
        IHasSyntax<IMethodSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
