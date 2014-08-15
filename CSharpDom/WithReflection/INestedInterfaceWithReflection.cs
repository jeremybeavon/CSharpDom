using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface INestedInterfaceWithReflection : IInterfaceWithSymbol, IHasType, IBasicTypeWithReflection,
        IHasDeclarations<INestedInterfaceDeclarationWithReflection>,
        IHasDeclaringType<ITypeWithReflection>,
        IHasSyntax<INestedInterfaceSyntax>,
        IHasSymbols<INestedInterfaceWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
