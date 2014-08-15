using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IStructWithReflection : IStructWithSymbol, IHasType,
        IHasDeclarations<IStructDeclarationWithReflection>,
        IHasNamespace<INamespaceWithReflection>,
        IHasProject<IProjectWithReflection>,
        IHasSolution<ISolutionWithReflection>,
        ITypeWithReflection,
        IHasSyntax<IStructSyntax>,
        IHasSymbols<IStructWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
