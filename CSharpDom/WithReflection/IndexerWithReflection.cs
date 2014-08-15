using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public sealed class IndexerWithReflection
    {
        private readonly IIndexerWithReflection indexer;

        public IndexerWithReflection(IIndexerWithReflection indexer)
        {
            this.indexer = indexer;
        }

        public IndexerDeclarationSyntax Declaration
        {
            get { return indexer.Declaration; }
        }

        public BasicTypeWithReflection DeclaringType
        {
            get { return BasicTypeWithReflection.GetBasicType(indexer.DeclaringType); }
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

        public IIndexerWithReflection AsInterface()
        {
            return indexer;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            indexer.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return indexer.ToString();
        }
    }
}
