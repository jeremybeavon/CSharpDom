using CSharpDom.Common;
using CSharpDom.WithSyntax;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols.Internal
{
    internal class ConversionOperatorNodeWithSymbols : ConversionOperatorNodeWithSyntax, IConversionOperatorWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private IMethodSymbol symbol;

        public ConversionOperatorNodeWithSymbols(
            ConversionOperatorDeclarationSyntax declaration,
            IMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container)
        {
            this.semanticModel = semanticModel;
        }

        public IMethodSymbol Symbol
        {
            get { return symbol ?? (symbol = semanticModel.GetDeclaredSymbol(Declaration)); }
        }

        public IConversionOperatorSyntax Syntax
        {
            get { return this; }
        }

        ITypeWithSymbols IHasDeclaringType<ITypeWithSymbols>.DeclaringType
        {
            get { return (ITypeWithSymbols)DeclaringType; }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }
    }
}
