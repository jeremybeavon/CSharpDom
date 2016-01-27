using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IIndexerWithSymbols :
        IIndexer<IBasicTypeWithSymbols>,
        IHasSymbol<IPropertySymbol>,
        IHasSyntax<IIndexerSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
