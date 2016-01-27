using System.Threading.Tasks;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IProjectSyntax : 
        IProject<ISolutionSyntax, IDocumentSyntax, ILoadedProjectWithSyntax>,
        IHasProject<Project>
    {
        Task AcceptAsync(ISyntaxVisitor visitor);
    }
}
