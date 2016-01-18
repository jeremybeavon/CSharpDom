using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class ProjectWithSyntax : AbstractAsyncSyntaxNode<IProjectSyntax>
    {
        private readonly IProjectSyntax project;

        private ProjectWithSyntax(IProjectSyntax project)
            : base(project)
        {
            this.project = project;
        }
        
        public IReadOnlyCollection<DocumentWithSyntax> Documents
        {
            get
            {
                return new ReadOnlyNodeCollection<DocumentWithSyntax, IDocumentSyntax>(
                    project.Documents,
                    document => new DocumentWithSyntax(document));
            }
        }
        
        public Project Project
        {
            get { return project.Project; }
        }

        public SolutionWithSyntax Solution
        {
            get { return SolutionWithSyntax.GetSolution(project.Solution); }
        }
        
        public static ProjectWithSyntax GetProject(IProjectSyntax project)
        {
            return project == null ? null : new ProjectWithSyntax(project);
        }

        public override Task AcceptAsync(SyntaxVisitor visitor)
        {
            return project.AcceptAsync(new SyntaxVisitorMapping(visitor));
        }
    }
}
