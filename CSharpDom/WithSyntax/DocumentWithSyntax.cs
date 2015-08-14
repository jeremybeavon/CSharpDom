using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSyntax
{
    public sealed class DocumentWithSyntax : AbstractSyntaxNode<IDocumentSyntax>
    {
        private readonly IDocumentSyntax document;

        public DocumentWithSyntax(IDocumentSyntax document)
            : base(document)
        {
            this.document = document;
        }

        public Document Document
        {
            get { return document.Document; }
        }

        public string FullFilePath
        {
            get { return document.FullFilePath; }
        }

        public ProjectWithSyntax Project
        {
            get { return ProjectWithSyntax.GetProject(document.Project); }
        }

        public SolutionWithSyntax Solution
        {
            get { return SolutionWithSyntax.GetSolution(document.Solution); }
        }

        public IDocumentSyntax AsInterface()
        {
            return document;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            document.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitDocument(this);
        }
    }
}
