using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface INestedStructWithSymbols : IStructWithSymbol, ITypeWithSymbols,
        IHasDeclaringType<ITypeWithSymbols>,
        IHasDeclarations<INestedStructDeclarationWithSymbols>,
        IHasSyntax<INestedStructSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
