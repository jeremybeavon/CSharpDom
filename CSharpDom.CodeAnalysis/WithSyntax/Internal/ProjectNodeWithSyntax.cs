using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class ProjectNodeWithSyntax : ProjectNode, IProjectSyntax
    {
        public ProjectNodeWithSyntax(Project project, SolutionNode solution)
            : base(project, solution)
        {
        }
        
        IReadOnlyCollection<IDocumentSyntax> IHasDocuments<IDocumentSyntax>.Documents
        {
            get { return new ReadOnlyNodeCollection<IDocumentSyntax, DocumentNode>(Documents); }
        }
        
        ISolutionSyntax IHasSolution<ISolutionSyntax>.Solution
        {
            get { return (ISolutionSyntax)Solution; }
        }
        
        public Task AcceptAsync(ISyntaxVisitor visitor)
        {
            return AcceptAsync(new SyntaxNodeVisitor(visitor));
        }

        async Task<ILoadedProjectWithSyntax> IProject<ISolutionSyntax, IDocumentSyntax, ILoadedProjectWithSyntax>.LoadAsync()
        {
            return (ILoadedProjectWithSyntax)(await LoadAsync());
        }
    }
}
