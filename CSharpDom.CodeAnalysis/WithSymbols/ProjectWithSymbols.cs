using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class ProjectWithSymbols : AbstractAsyncSymbolNode<IProjectWithSymbols>
    {
        private readonly IProjectWithSymbols project;

        private ProjectWithSymbols(IProjectWithSymbols project)
            : base(project)
        {
            this.project = project;
        }
        
        public IReadOnlyCollection<DocumentWithSymbols> Documents
        {
            get
            {
                return new ReadOnlyNodeCollection<DocumentWithSymbols, IDocumentWithSymbols>(
                    project.Documents,
                    document => new DocumentWithSymbols(document));
            }
        }
        
        public Project Project
        {
            get { return project.Project; }
        }

        public SolutionWithSymbols Solution
        {
            get { return SolutionWithSymbols.GetSolution(project.Solution); }
        }
        
        public static ProjectWithSymbols GetProject(IProjectWithSymbols project)
        {
            return project == null ? null : new ProjectWithSymbols(project);
        }

        public override Task AcceptAsync(SymbolsVisitor visitor)
        {
            return project.AcceptAsync(new SymbolsVisitorMapping(visitor));
        }
    }
}
