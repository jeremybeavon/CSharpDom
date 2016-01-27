using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IEventWithSymbols :
        IEvent<IBasicTypeWithSymbols>,
        IHasSymbol<IEventSymbol>,
        IHasSyntax<IEventSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
