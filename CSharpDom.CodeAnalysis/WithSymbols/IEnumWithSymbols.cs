using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IEnumWithSymbols : 
        IEnum<INamespaceWithSymbols, IProjectWithSymbols, ISolutionWithSymbols, IEnumMemberWithSymbols>,
        IHasSymbol<INamedTypeSymbol>,
        IHasSyntax<IEnumSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
