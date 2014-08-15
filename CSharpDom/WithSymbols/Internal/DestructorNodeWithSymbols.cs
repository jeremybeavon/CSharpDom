using System;
using CSharpDom.Common;
using CSharpDom.WithSyntax;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols.Internal
{
    internal class DestructorNodeWithSymbols : DestructorNodeWithSyntax, IDestructorWithSymbols,
        INestedDestructorWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private IMethodSymbol symbol;

        public DestructorNodeWithSymbols(
            DestructorDeclarationSyntax declaration,
            ClassDeclarationNode container,
            SemanticModel semanticModel)
            : base(declaration, container)
        {
            this.semanticModel = semanticModel;
        }

        public IMethodSymbol Symbol
        {
            get { return symbol ?? (symbol = semanticModel.GetDeclaredSymbol(Declaration)); }
        }

        public IDestructorSyntax Syntax
        {
            get { return this; }
        }

        INestedClassDeclarationWithSymbols IHasDeclaringType<INestedClassDeclarationWithSymbols>.DeclaringType
        {
            get { return (INestedClassDeclarationWithSymbols)DeclaringType; }
        }

        IClassDeclarationWithSymbols IHasDeclaringType<IClassDeclarationWithSymbols>.DeclaringType
        {
            get { return (IClassDeclarationWithSymbols)DeclaringType; }
        }

        INestedDestructorSyntax IHasSyntax<INestedDestructorSyntax>.Syntax
        {
            get { return this; }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }
    }
}
