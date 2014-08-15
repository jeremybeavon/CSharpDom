using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface INestedInterfaceWithSymbols : IInterfaceWithSymbol, IBasicTypeWithSymbols,
        IHasDeclarations<INestedInterfaceDeclarationWithSymbols>,
        IHasDeclaringType<ITypeWithSymbols>,
        IHasSyntax<INestedInterfaceSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
