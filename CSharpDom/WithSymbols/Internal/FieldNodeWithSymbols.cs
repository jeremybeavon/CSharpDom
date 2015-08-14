using CSharpDom.Common;
using CSharpDom.WithSyntax;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols.Internal
{
    internal class FieldNodeWithSymbols : FieldNodeWithSyntax, IFieldWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private IFieldSymbol symbol;

        public FieldNodeWithSymbols(
            FieldDeclarationSyntax declaration,
            IMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container)
        {
            this.semanticModel = semanticModel;
        }

        public IFieldSymbol Symbol
        {
            get { return symbol ?? (symbol = (IFieldSymbol)semanticModel.GetDeclaredSymbol(Declaration.Declaration.Variables[0])); }
        }

        public IFieldSyntax Syntax
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
