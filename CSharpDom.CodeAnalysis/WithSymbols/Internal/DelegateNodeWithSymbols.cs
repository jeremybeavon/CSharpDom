using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal class DelegateNodeWithSymbols : DelegateNodeWithSyntax, IDelegateWithSymbols, INestedDelegateWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private INamedTypeSymbol symbol;

        public DelegateNodeWithSymbols(
            DelegateDeclarationSyntax declaration,
            ITypeContainer container,
            SemanticModel semanticModel)
            : base(declaration, container)
        {
            this.semanticModel = semanticModel;
        }

        public INamedTypeSymbol Symbol
        {
            get { return symbol ?? (symbol = semanticModel.GetDeclaredSymbol(Declaration)); }
        }

        public IDelegateSyntax Syntax
        {
            get { return this; }
        }

        ITypeWithSymbols IHasDeclaringType<ITypeWithSymbols>.DeclaringType
        {
            get { return (ITypeWithSymbols)DeclaringType; }
        }

        INamespaceWithSymbols IHasNamespace<INamespaceWithSymbols>.Namespace
        {
            get { return (INamespaceWithSymbols)Namespace; }
        }

        IProjectWithSymbols IHasProject<IProjectWithSymbols>.Project
        {
            get { return (IProjectWithSymbols)Project; }
        }

        ISolutionWithSymbols IHasSolution<ISolutionWithSymbols>.Solution
        {
            get { return (ISolutionWithSymbols)Solution; }
        }

        INestedDelegateSyntax IHasSyntax<INestedDelegateSyntax>.Syntax
        {
            get { return this; }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }
    }
}
