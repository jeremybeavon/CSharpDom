using System;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSyntax.Internal
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
    }
}
