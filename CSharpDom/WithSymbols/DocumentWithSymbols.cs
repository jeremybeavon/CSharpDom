using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public sealed class DocumentWithSymbols : AbstractSymbolNode<IDocumentWithSymbols>
    {
        private readonly IDocumentWithSymbols document;

        public DocumentWithSymbols(IDocumentWithSymbols document)
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

        public ProjectWithSymbols Project
        {
            get { return ProjectWithSymbols.GetProject(document.Project); }
        }

        public SolutionWithSymbols Solution
        {
            get { return SolutionWithSymbols.GetSolution(document.Solution); }
        }

        public IDocumentWithSymbols AsInterface()
        {
            return document;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            document.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
