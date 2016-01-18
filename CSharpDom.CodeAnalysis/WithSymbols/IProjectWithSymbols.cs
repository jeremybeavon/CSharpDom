using System.Threading.Tasks;
using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IProjectWithSymbols : 
        IProject<ISolutionWithSymbols, IDocumentWithSymbols, ILoadedProjectWithSymbols>,
        IHasSolution<ISolutionWithSymbols>,
        IHasProject<Project>,
        IHasSyntax<IProjectSyntax>
    {
        Task AcceptAsync(ISymbolsVisitor visitor);
    }
}
