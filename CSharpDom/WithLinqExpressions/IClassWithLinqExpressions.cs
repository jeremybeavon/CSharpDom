using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IClassWithLinqExpressions : IClassWithSymbol, IHasType,
        IHasDeclarations<IClassDeclarationWithLinqExpressions>,
        IHasNamespace<INamespaceWithLinqExpressions>,
        IHasProject<IProjectWithLinqExpressions>,
        IHasSolution<ISolutionWithLinqExpressions>,
        ITypeWithLinqExpressions,
        IHasDestructor<IDestructorWithLinqExpressions>,
        IHasSyntax<IClassSyntax>,
        IHasSymbols<IClassWithSymbols>,
        IHasReflection<IClassWithReflection>
    {
    }
}
