using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
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

        INestedClassWithSymbols IHasDeclaringType<INestedClassWithSymbols>.DeclaringType
        {
            get { return (INestedClassWithSymbols)DeclaringType; }
        }

        IClassWithSymbols IHasDeclaringType<IClassWithSymbols>.DeclaringType
        {
            get { return (IClassWithSymbols)DeclaringType; }
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
