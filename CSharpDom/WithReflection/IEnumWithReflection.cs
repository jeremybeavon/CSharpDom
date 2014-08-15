using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public interface IEnumWithReflection : IEnum, IHasSymbol<INamedTypeSymbol>,
        IHasEnumMembers<IEnumMemberWithReflection>,
        IHasNamespace<INamespaceWithReflection>,
        IHasProject<IProjectWithReflection>,
        IHasSolution<ISolutionWithReflection>,
        IHasSyntax<IEnumSyntax>,
        IHasSymbols<IEnumWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
