using CSharpDom.Common;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public interface IEnumWithSymbols : IEnum, IHasSymbol<INamedTypeSymbol>,
        IHasEnumMembers<IEnumMemberWithSymbols>,
        IHasNamespace<INamespaceWithSymbols>,
        IHasProject<IProjectWithSymbols>,
        IHasSolution<ISolutionWithSymbols>,
        IHasSyntax<IEnumSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
