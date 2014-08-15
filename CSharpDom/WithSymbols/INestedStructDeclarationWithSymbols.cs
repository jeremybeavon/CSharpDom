using CSharpDom.Common;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public interface INestedStructDeclarationWithSymbols : IStructWithSymbol, ITypeWithSymbols,
        IHasDeclaration<StructDeclarationSyntax>,
        IHasDeclaringType<ITypeWithSymbols>,
        IHasCompositeType<INestedStructWithSymbols>,
        IHasSyntax<INestedStructDeclarationSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
