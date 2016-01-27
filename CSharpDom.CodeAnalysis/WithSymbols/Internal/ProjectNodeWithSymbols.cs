using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal class ProjectNodeWithSymbols : ProjectNodeWithSyntax, IProjectWithSymbols
    {
        public ProjectNodeWithSymbols(Project project, SolutionNode solution)
            : base(project, solution)
        {
        }

        public IProjectSyntax Syntax
        {
            get { return this; }
        }

        IReadOnlyCollection<IDocumentWithSymbols> IHasDocuments<IDocumentWithSymbols>.Documents
        {
            get { return new ReadOnlyNodeCollection<IDocumentWithSymbols, DocumentNode>(Documents); }
        }

        ISolutionWithSymbols IHasSolution<ISolutionWithSymbols>.Solution
        {
            get { return (ISolutionWithSymbols)Solution; }
        }

        public Task AcceptAsync(ISymbolsVisitor visitor)
        {
            return AcceptAsync(new SymbolsNodeVisitor(visitor));
        }

        protected sealed override async Task<INodeFactory> GetNodeFactory(DocumentNode document)
        {
            return GetNodeFactory(await document.Document.GetSemanticModelAsync());
        }

        protected virtual INodeFactory GetNodeFactory(SemanticModel semanticModel)
        {
            return new SymbolNodeFactory(semanticModel);
        }

        async Task<ILoadedProjectWithSymbols> IProject<ISolutionWithSymbols, IDocumentWithSymbols, ILoadedProjectWithSymbols>.LoadAsync()
        {
            return (ILoadedProjectWithSymbols)(await LoadAsync());
        }
    }
}
