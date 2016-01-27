using System.Threading.Tasks;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface ISolutionSyntax : ISolution<IProjectSyntax>, IHasSolution<Solution>
    {
        Task AcceptAsync(ISyntaxVisitor visitor);
    }
}
