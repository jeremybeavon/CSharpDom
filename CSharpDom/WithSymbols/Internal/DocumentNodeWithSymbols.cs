using System;
using CSharpDom.Common;
using CSharpDom.WithSyntax;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols.Internal
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
    }
}
