using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithSyntax;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols.Internal
{
    internal class EnumNodeWithSymbols : EnumNodeWithSyntax, IEnumWithSymbols, INestedEnumWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private INamedTypeSymbol symbol;

        public EnumNodeWithSymbols(
            EnumDeclarationSyntax declaration,
            ITypeContainer container,
            SemanticModel semanticModel)
            : base(declaration, container)
        {
            this.semanticModel = semanticModel;
        }

        public INamedTypeSymbol Symbol
        {
            get { return symbol ?? (symbol = (INamedTypeSymbol)semanticModel.GetDeclaredSymbol(Declaration)); }
        }

        public INestedEnumSyntax Syntax
        {
            get { return this; }
        }

        ITypeWithSymbols IHasDeclaringType<ITypeWithSymbols>.DeclaringType
        {
            get { return (ITypeWithSymbols)DeclaringType; }
        }

        IReadOnlyCollection<IEnumMemberWithSymbols> IHasEnumMembers<IEnumMemberWithSymbols>.EnumMembers
        {
            get { return new ReadOnlyNodeCollection<IEnumMemberWithSymbols, EnumMemberNode>(EnumMembers); }
        }

        IReadOnlyCollection<INestedEnumMemberWithSymbols> IHasEnumMembers<INestedEnumMemberWithSymbols>.EnumMembers
        {
            get { return new ReadOnlyNodeCollection<INestedEnumMemberWithSymbols, EnumMemberNode>(EnumMembers); }
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

        IEnumSyntax IHasSyntax<IEnumSyntax>.Syntax
        {
            get { return this; }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }
    }
}
