using CSharpDom.Common;
using CSharpDom.WithSyntax;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols.Internal
{
    internal class EventPropertyNodeWithSymbols : EventPropertyNodeWithSyntax, IEventPropertyWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private IEventSymbol symbol;

        public EventPropertyNodeWithSymbols(
            EventDeclarationSyntax declaration,
            IMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container)
        {
            this.semanticModel = semanticModel;
        }

        public IEventSymbol Symbol
        {
            get { return symbol ?? (symbol = semanticModel.GetDeclaredSymbol(Declaration)); }
        }

        public IEventPropertySyntax Syntax
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
