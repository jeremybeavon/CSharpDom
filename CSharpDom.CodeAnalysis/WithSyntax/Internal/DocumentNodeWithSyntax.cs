using System;
using System.Threading.Tasks;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class DocumentNodeWithSyntax : DocumentNode, IDocumentSyntax
    {
        public DocumentNodeWithSyntax(Document document, ProjectNode project)
            : base(document, project)
        {
        }

        IProjectSyntax IHasProject<IProjectSyntax>.Project
        {
            get { return (IProjectSyntax)Project; }
        }

        ISolutionSyntax IHasSolution<ISolutionSyntax>.Solution
        {
            get { return (ISolutionSyntax)Solution; }
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            Accept(new SyntaxNodeVisitor(visitor));
        }

        public override AbstractSyntaxNode CreateNode()
        {
            return new DocumentWithSyntax(this);
        }

        async Task<ILoadedDocumentWithSyntax> IDocument<IProjectSyntax, ISolutionSyntax, ILoadedDocumentWithSyntax>.LoadAsync()
        {
            return (ILoadedDocumentWithSyntax)(await LoadAsync());
        }
    }
}
