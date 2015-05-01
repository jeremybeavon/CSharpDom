using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class IndexerWithLinqExpressions
    {
        private readonly IIndexerWithLinqExpressions indexer;

        public IndexerWithLinqExpressions(IIndexerWithLinqExpressions indexer)
        {
            this.indexer = indexer;
        }

        public IndexerDeclarationSyntax Declaration
        {
            get { return indexer.Declaration; }
        }

        public BasicTypeWithLinqExpressions DeclaringType
        {
            get { return BasicTypeWithLinqExpressions.GetBasicType(indexer.DeclaringType); }
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

        public IIndexerWithLinqExpressions AsInterface()
        {
            return indexer;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            indexer.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return indexer.ToString();
        }
    }
}
