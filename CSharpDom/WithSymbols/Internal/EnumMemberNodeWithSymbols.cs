using System;
using CSharpDom.Common;
using CSharpDom.WithSyntax;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols.Internal
{
    internal class EnumMemberNodeWithSymbols : EnumMemberNodeWithSyntax, IEnumMemberWithSymbols,
        INestedEnumMemberWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private IFieldSymbol symbol;

        public EnumMemberNodeWithSymbols(
            EnumMemberDeclarationSyntax declaration,
            EnumNode container,
            SemanticModel semanticModel)
            : base(declaration, container)
        {
            this.semanticModel = semanticModel;
        }

        public IFieldSymbol Symbol
        {
            get { return symbol ?? (symbol = (IFieldSymbol)semanticModel.GetDeclaredSymbol(Declaration)); }
        }

        public IEnumMemberSyntax Syntax
        {
            get { return this; }
        }

        INestedEnumWithSymbols IHasDeclaringType<INestedEnumWithSymbols>.DeclaringType
        {
            get { return (INestedEnumWithSymbols)DeclaringType; }
        }

        IEnumWithSymbols IHasDeclaringType<IEnumWithSymbols>.DeclaringType
        {
            get { return (IEnumWithSymbols)DeclaringType; }
        }

        INestedEnumMemberSyntax IHasSyntax<INestedEnumMemberSyntax>.Syntax
        {
            get { return this; }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }
    }
}
