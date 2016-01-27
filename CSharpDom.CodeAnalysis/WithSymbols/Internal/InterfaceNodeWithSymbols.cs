using System.Collections.Generic;
using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal class InterfaceNodeWithSymbols : InterfaceNodeWithSyntax, IInterfaceWithSymbols, INestedInterfaceWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private INamedTypeSymbol symbol;

        public InterfaceNodeWithSymbols(InterfaceDeclarationSyntax declaration, ITypeContainer container, SemanticModel semanticModel)
            : base(declaration, container)
        {
            this.semanticModel = semanticModel;
        }

        public INamedTypeSymbol Symbol
        {
            get { return symbol ?? (symbol = semanticModel.GetDeclaredSymbol(Declarations[0].Declaration)); }
        }

        public IInterfaceSyntax Syntax
        {
            get { return this; }
        }
        
        ITypeWithSymbols IHasDeclaringType<ITypeWithSymbols>.DeclaringType
        {
            get { return (ITypeWithSymbols)DeclaringType; }
        }

        IReadOnlyCollection<IEventWithSymbols> IHasEvents<IEventWithSymbols>.Events
        {
            get { return new ReadOnlyNodeCollection<IEventWithSymbols, EventNode>(Events); }
        }

        IReadOnlyCollection<IIndexerWithSymbols> IHasIndexers<IIndexerWithSymbols>.Indexers
        {
            get { return new ReadOnlyNodeCollection<IIndexerWithSymbols, IndexerNode>(Indexers); }
        }

        IReadOnlyCollection<IMethodWithSymbols> IHasMethods<IMethodWithSymbols>.Methods
        {
            get { return new ReadOnlyNodeCollection<IMethodWithSymbols, MethodNode>(Methods); }
        }

        INamespaceWithSymbols IHasNamespace<INamespaceWithSymbols>.Namespace
        {
            get { return (INamespaceWithSymbols)Namespace; }
        }

        IProjectWithSymbols IHasProject<IProjectWithSymbols>.Project
        {
            get { return (IProjectWithSymbols)Project; }
        }

        IReadOnlyCollection<IPropertyWithSymbols> IHasProperties<IPropertyWithSymbols>.Properties
        {
            get { return new ReadOnlyNodeCollection<IPropertyWithSymbols, PropertyNode>(Properties); }
        }

        ISolutionWithSymbols IHasSolution<ISolutionWithSymbols>.Solution
        {
            get { return (ISolutionWithSymbols)Solution; }
        }

        INestedInterfaceSyntax IHasSyntax<INestedInterfaceSyntax>.Syntax
        {
            get { return this; }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }
    }
}
