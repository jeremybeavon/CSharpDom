using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithSyntax;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols.Internal
{
    internal class InterfaceDeclarationNodeWithSymbols : InterfaceDeclarationNodeWithSyntax,
        IInterfaceDeclarationWithSymbols,
        INestedInterfaceDeclarationWithSymbols
    {
        private readonly SemanticModel semanticModel;
        private INamedTypeSymbol symbol;

        public InterfaceDeclarationNodeWithSymbols(
            InterfaceDeclarationSyntax declaration,
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

        public IInterfaceDeclarationSyntax Syntax
        {
            get { return this; }
        }

        INestedInterfaceWithSymbols IHasCompositeType<INestedInterfaceWithSymbols>.CompositeType
        {
            get { return (INestedInterfaceWithSymbols)CompositeType; }
        }

        IInterfaceWithSymbols IHasCompositeType<IInterfaceWithSymbols>.CompositeType
        {
            get { return (IInterfaceWithSymbols)CompositeType; }
        }

        ITypeWithSymbols IHasDeclaringType<ITypeWithSymbols>.DeclaringType
        {
            get { return (ITypeWithSymbols)DeclaringType; }
        }

        IDocumentWithSymbols IHasDocument<IDocumentWithSymbols>.Document
        {
            get { return (IDocumentWithSymbols)Document; }
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

        INestedInterfaceDeclarationSyntax IHasSyntax<INestedInterfaceDeclarationSyntax>.Syntax
        {
            get { return this; }
        }

        public void Accept(ISymbolsVisitor visitor)
        {
            Accept(new SymbolsNodeVisitor(visitor));
        }
    }
}
