using CSharpDom.Common;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public interface INestedInterfaceDeclarationWithSymbols : IInterfaceWithSymbol, IBasicTypeWithSymbols,
        IHasDeclaration<InterfaceDeclarationSyntax>,
        IHasDeclaringType<ITypeWithSymbols>,
        IHasCompositeType<INestedInterfaceWithSymbols>,
        IHasSyntax<INestedInterfaceDeclarationSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
