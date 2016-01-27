using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class IndexerWithSymbols : AbstractSymbolNode<IIndexerWithSymbols>
    {
        private readonly IIndexerWithSymbols indexer;

        public IndexerWithSymbols(IIndexerWithSymbols indexer)
            : base(indexer)
        {
            this.indexer = indexer;
        }
        
        public BasicTypeWithSymbols DeclaringType
        {
            get { return BasicTypeWithSymbols.GetBasicType(indexer.DeclaringType); }
        }
        
        public bool HasGet
        {
            get { return indexer.HasGet; }
        }

        public bool HasSet
        {
            get { return indexer.HasSet; }
        }
        
        public IPropertySymbol Symbol
        {
            get { return indexer.Symbol; }
        }

        public IIndexerWithSymbols AsInterface()
        {
            return indexer;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            indexer.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
