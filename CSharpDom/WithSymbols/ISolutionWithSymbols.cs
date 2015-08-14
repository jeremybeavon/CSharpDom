using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface ISolutionWithSymbols : ISolution<IProjectWithSymbols>, IHasSyntax<ISolutionSyntax>
    {
        Task AcceptAsync(ISymbolsVisitor visitor);
    }
}
