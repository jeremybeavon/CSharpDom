using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IInterfaceWithReflection : IInterfaceWithSymbol, IHasType, IBasicTypeWithReflection,
        IHasDeclarations<IInterfaceDeclarationWithReflection>,
        IHasNamespace<INamespaceWithReflection>,
        IHasProject<IProjectWithReflection>,
        IHasSolution<ISolutionWithReflection>,
        IHasSyntax<IInterfaceSyntax>,
        IHasSymbols<IInterfaceWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
