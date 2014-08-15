using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IProjectWithSymbols : IProject<IDocumentWithSymbols>,
        IHasSolution<ISolutionWithSymbols>,
        ISymbolContainer,
        IHasSyntax<IProjectSyntax>
    {
        Task AcceptAsync(ISymbolsVisitor visitor);
    }
}
