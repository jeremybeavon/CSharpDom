using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithSyntax;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols.Internal
{
    internal class InterfaceNodeWithSymbols : InterfaceNodeWithSyntax, IInterfaceWithSymbols, INestedInterfaceWithSymbols
    {
        public InterfaceNodeWithSymbols(InterfaceDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        public INamedTypeSymbol Symbol
        {
            get { return ((IHasSymbol<INamedTypeSymbol>)Declarations[0]).Symbol; }
        }

        public IInterfaceSyntax Syntax
        {
            get { return this; }
        }

        IReadOnlyCollection<INestedInterfaceDeclarationWithSymbols> IHasDeclarations<INestedInterfaceDeclarationWithSymbols>.Declarations
        {
            get { return new ReadOnlyNodeCollection<INestedInterfaceDeclarationWithSymbols, InterfaceDeclarationNode>(Declarations); }
        }

        IReadOnlyCollection<IInterfaceDeclarationWithSymbols> IHasDeclarations<IInterfaceDeclarationWithSymbols>.Declarations
        {
            get { return new ReadOnlyNodeCollection<IInterfaceDeclarationWithSymbols, InterfaceDeclarationNode>(Declarations); }
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
