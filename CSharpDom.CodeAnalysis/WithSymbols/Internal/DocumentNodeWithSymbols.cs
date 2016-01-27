using System;
using System.Threading.Tasks;
using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal class DocumentNodeWithSymbols : DocumentNodeWithSyntax, IDocumentWithSymbols
    {
        public DocumentNodeWithSymbols(Document document, ProjectNode project)
            : base(document, project)
        {
        }

        public IDocumentSyntax Syntax
        {
            get { return this; }
        }

        IProjectWithSymbols IHasProject<IProjectWithSymbols>.Project
        {
            get { return (IProjectWithSymbols)Project; }
        }

        ISolutionWithSymbols IHasSolution<ISolutionWithSymbols>.Solution
        {
            get { return (ISolutionWithSymbols)Solution; }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }

        async Task<ILoadedDocumentWithSymbols> IDocument<IProjectWithSymbols, ISolutionWithSymbols, ILoadedDocumentWithSymbols>.LoadAsync()
        {
            return (ILoadedDocumentWithSymbols)(await LoadAsync());
        }
    }
}
