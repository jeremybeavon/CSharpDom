using CSharpDom.Common;
using CSharpDom.WithSyntax;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols.Internal
{
    internal class IndexerNodeWithSymbols : IndexerNodeWithSyntax, IIndexerWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private IPropertySymbol symbol;

        public IndexerNodeWithSymbols(
            IndexerDeclarationSyntax declaration,
            IBasicMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container)
        {
            this.semanticModel = semanticModel;
        }

        public IPropertySymbol Symbol
        {
            get { return symbol ?? (symbol = semanticModel.GetDeclaredSymbol(Declaration)); }
        }

        public IIndexerSyntax Syntax
        {
            get { return this; }
        }

        IBasicTypeWithSymbols IHasDeclaringType<IBasicTypeWithSymbols>.DeclaringType
        {
            get { return (IBasicTypeWithSymbols)DeclaringType; }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }
    }
}
