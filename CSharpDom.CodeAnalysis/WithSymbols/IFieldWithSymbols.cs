using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IFieldWithSymbols :
        IField<ITypeWithSymbols>,
        IHasSymbol<IFieldSymbol>,
        IHasSyntax<IFieldSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
