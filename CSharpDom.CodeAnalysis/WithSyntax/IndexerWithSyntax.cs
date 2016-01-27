using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class IndexerWithSyntax : AbstractSyntaxNode<IIndexerSyntax>
    {
        private readonly IIndexerSyntax indexer;

        public IndexerWithSyntax(IIndexerSyntax indexer)
            : base(indexer)
        {
            this.indexer = indexer;
        }

        public IndexerDeclarationSyntax Declaration
        {
            get { return indexer.Declaration; }
        }

        public BasicTypeWithSyntax DeclaringType
        {
            get { return BasicTypeWithSyntax.GetBasicType(indexer.DeclaringType); }
        }

        public int EndLine
        {
            get { return indexer.EndLine; }
        }

        public bool HasGet
        {
            get { return indexer.HasGet; }
        }

        public bool HasSet
        {
            get { return indexer.HasSet; }
        }

        public int StartLine
        {
            get { return indexer.StartLine; }
        }

        public IIndexerSyntax AsInterface()
        {
            return indexer;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            indexer.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitIndexer(this);
        }
    }
}
