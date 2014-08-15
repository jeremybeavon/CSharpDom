using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public interface INestedInterfaceDeclarationWithReflection : IInterfaceWithSymbol, IBasicTypeWithReflection,
        IHasDeclaration<InterfaceDeclarationSyntax>,
        IHasDeclaringType<ITypeWithReflection>,
        IHasCompositeType<INestedInterfaceWithReflection>,
        IHasSyntax<INestedInterfaceDeclarationSyntax>,
        IHasSymbols<INestedInterfaceDeclarationWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
