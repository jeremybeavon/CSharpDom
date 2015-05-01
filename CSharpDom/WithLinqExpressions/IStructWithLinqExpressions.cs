using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IStructWithLinqExpressions : IStructWithSymbol, IHasType,
        IHasDeclarations<IStructDeclarationWithLinqExpressions>,
        IHasNamespace<INamespaceWithLinqExpressions>,
        IHasProject<IProjectWithLinqExpressions>,
        IHasSolution<ISolutionWithLinqExpressions>,
        ITypeWithLinqExpressions,
        IHasSyntax<IStructSyntax>,
        IHasSymbols<IStructWithSymbols>,
        IHasReflection<IStructWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
