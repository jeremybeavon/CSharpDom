using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class IndexerWithSymbols : AbstractSymbolNode<IIndexerWithSymbols>
    {
        private readonly IIndexerWithSymbols indexer;

        public IndexerWithSymbols(IIndexerWithSymbols indexer)
            : base(indexer)
        {
            this.indexer = indexer;
        }

        public IndexerDeclarationSyntax Declaration
        {
            get { return indexer.Declaration; }
        }

        public BasicTypeWithSymbols DeclaringType
        {
            get { return BasicTypeWithSymbols.GetBasicType(indexer.DeclaringType); }
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
