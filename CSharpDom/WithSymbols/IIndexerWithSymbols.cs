using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IIndexerWithSymbols : IIndexerWithSymbol, IHasDeclaringType<IBasicTypeWithSymbols>,
        IHasSyntax<IIndexerSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
