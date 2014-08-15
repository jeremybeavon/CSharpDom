using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IInterfaceWithLinqExpressions : IInterfaceWithSymbol, IHasType, IBasicTypeWithLinqExpressions,
        IHasDeclarations<IInterfaceDeclarationWithLinqExpressions>,
        IHasNamespace<INamespaceWithLinqExpressions>,
        IHasProject<IProjectWithLinqExpressions>,
        IHasSolution<ISolutionWithLinqExpressions>,
        IHasSyntax<IInterfaceSyntax>,
        IHasSymbols<IInterfaceWithSymbols>,
        IHasReflection<IInterfaceWithReflection>
    {
    }
}
