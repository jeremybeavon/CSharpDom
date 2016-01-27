using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IEventPropertyWithSymbols :
        IEventProperty<ITypeWithSymbols>,
        IHasSymbol<IEventSymbol>,
        IHasSyntax<IEventPropertySyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
