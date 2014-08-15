using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IEventWithSymbols : IEventWithSymbol, IHasDeclaringType<IBasicTypeWithSymbols>,
        IHasSyntax<IEventSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
