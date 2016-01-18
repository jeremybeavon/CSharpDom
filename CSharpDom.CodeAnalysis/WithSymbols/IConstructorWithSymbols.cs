using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IConstructorWithSymbols :
        IConstructor<ITypeWithSymbols>,
        IHasSymbol<IMethodSymbol>,
        IHasSyntax<IConstructorSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
