using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IDelegateWithLinqExpressions : IDelegateWithSymbol, IHasType,
        IHasNamespace<INamespaceWithLinqExpressions>,
        IHasProject<IProjectWithLinqExpressions>,
        IHasSolution<ISolutionWithLinqExpressions>,
        IHasSyntax<IDelegateSyntax>,
        IHasSymbols<IDelegateWithSymbols>,
        IHasReflection<IDelegateWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
