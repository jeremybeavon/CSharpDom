﻿using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal class EventNodeWithSymbols : EventNodeWithSyntax, IEventWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private IEventSymbol symbol;

        public EventNodeWithSymbols(
            EventFieldDeclarationSyntax declaration,
            IBasicMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container)
        {
            this.semanticModel = semanticModel;
        }

        public IEventSymbol Symbol
        {
            get { return symbol ?? (symbol = (IEventSymbol)semanticModel.GetDeclaredSymbol(Declaration)); }
        }

        IBasicTypeWithSymbols IHasDeclaringType<IBasicTypeWithSymbols>.DeclaringType
        {
            get { return (IBasicTypeWithSymbols)DeclaringType; }
        }

        IEventSyntax IHasSyntax<IEventSyntax>.Syntax
        {
            get { return this; }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }
    }
}
