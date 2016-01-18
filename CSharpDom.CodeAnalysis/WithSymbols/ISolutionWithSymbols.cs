using System.Threading.Tasks;
using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface ISolutionWithSymbols : ISolution<IProjectWithSymbols>, IHasSolution<Solution>, IHasSyntax<ISolutionSyntax>
    {
        Task AcceptAsync(ISymbolsVisitor visitor);
    }
}
