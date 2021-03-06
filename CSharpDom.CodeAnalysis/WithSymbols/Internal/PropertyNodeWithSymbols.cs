﻿using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal class PropertyNodeWithSymbols : PropertyNodeWithSyntax, IPropertyWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private IPropertySymbol symbol;

        public PropertyNodeWithSymbols(
            PropertyDeclarationSyntax declaration,
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

        public IPropertySyntax Syntax
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
