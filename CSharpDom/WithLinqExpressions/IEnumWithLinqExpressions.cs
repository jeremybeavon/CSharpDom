using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public interface IEnumWithLinqExpressions : IEnum, IHasSymbol<INamedTypeSymbol>,
        IHasEnumMembers<IEnumMemberWithLinqExpressions>,
        IHasNamespace<INamespaceWithLinqExpressions>,
        IHasProject<IProjectWithLinqExpressions>,
        IHasSolution<ISolutionWithLinqExpressions>,
        IHasSyntax<IEnumSyntax>,
        IHasSymbols<IEnumWithSymbols>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
