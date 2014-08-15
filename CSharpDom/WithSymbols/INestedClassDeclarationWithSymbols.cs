using CSharpDom.Common;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public interface INestedClassDeclarationWithSymbols : IClassWithSymbol, ITypeWithSymbols,
        IHasDeclaration<ClassDeclarationSyntax>,
        IHasDeclaringType<ITypeWithSymbols>,
        IHasCompositeType<INestedClassWithSymbols>,
        IHasSyntax<INestedClassDeclarationSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
