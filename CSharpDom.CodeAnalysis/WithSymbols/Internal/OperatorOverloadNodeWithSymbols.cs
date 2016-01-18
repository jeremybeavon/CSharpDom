using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal class OperatorOverloadNodeWithSymbols : OperatorOverloadNodeWithSyntax, IOperatorOverloadWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private IMethodSymbol symbol;

        public OperatorOverloadNodeWithSymbols(
            OperatorDeclarationSyntax declaration,
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

        public IOperatorOverloadSyntax Syntax
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
