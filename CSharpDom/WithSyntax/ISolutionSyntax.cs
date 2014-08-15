using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface ISolutionSyntax : ISolution<IProjectSyntax>
    {
        Task AcceptAsync(ISyntaxVisitor visitor);
    }
}
