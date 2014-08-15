using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IProjectSyntax : IProject<IDocumentSyntax>,
        IHasSolution<ISolutionSyntax>,
        ISyntaxContainer
    {
        Task AcceptAsync(ISyntaxVisitor visitor);
    }
}
