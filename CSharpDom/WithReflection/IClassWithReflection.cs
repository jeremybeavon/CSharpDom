using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IClassWithReflection : IClassWithSymbol, IHasType,
        IHasDeclarations<IClassDeclarationWithReflection>,
        IHasNamespace<INamespaceWithReflection>,
        IHasProject<IProjectWithReflection>,
        IHasSolution<ISolutionWithReflection>,
        ITypeWithReflection,
        IHasDestructor<IDestructorWithReflection>,
        IHasSyntax<IClassSyntax>,
        IHasSymbols<IClassWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
