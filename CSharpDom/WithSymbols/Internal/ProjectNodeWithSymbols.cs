using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.Internal;
using CSharpDom.WithSyntax;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols.Internal
{
    internal class ProjectNodeWithSymbols : ProjectNodeWithSyntax, IProjectWithSymbols
    {
        public ProjectNodeWithSymbols(Project project, SolutionNode solution)
            : base(project, solution)
        {
        }

        public IProjectSyntax Syntax
        {
            get { return this; }
        }

        IAsyncEnumerable<IClassWithSymbols, IDocumentWithSymbols> ISymbolContainer.Classes
        {
            get { return new AsyncEnumerable<IClassWithSymbols, ClassNode, IDocumentWithSymbols>(Classes); }
        }

        IAsyncEnumerable<IDelegateWithSymbols, IDocumentWithSymbols> ISymbolContainer.Delegates
        {
            get { return new AsyncEnumerable<IDelegateWithSymbols, DelegateNode, IDocumentWithSymbols>(Delegates); }
        }

        IReadOnlyCollection<IDocumentWithSymbols> IProject<IDocumentWithSymbols>.Documents
        {
            get { return new ReadOnlyNodeCollection<IDocumentWithSymbols, DocumentNode>(Documents); }
        }

        IAsyncEnumerable<IEnumWithSymbols, IDocumentWithSymbols> ISymbolContainer.Enums
        {
            get { return new AsyncEnumerable<IEnumWithSymbols, EnumNode, IDocumentWithSymbols>(Enums); }
        }

        IAsyncEnumerable<IInterfaceWithSymbols, IDocumentWithSymbols> ISymbolContainer.Interfaces
        {
            get { return new AsyncEnumerable<IInterfaceWithSymbols, InterfaceNode, IDocumentWithSymbols>(Interfaces); }
        }

        IAsyncEnumerable<INamespaceWithSymbols, IDocumentWithSymbols> ISymbolContainer.Namespaces
        {
            get { return new AsyncEnumerable<INamespaceWithSymbols, NamespaceNode, IDocumentWithSymbols>(Namespaces); }
        }

        ISolutionWithSymbols IHasSolution<ISolutionWithSymbols>.Solution
        {
            get { return (ISolutionWithSymbols)Solution; }
        }

        IAsyncEnumerable<IStructWithSymbols, IDocumentWithSymbols> ISymbolContainer.Structs
        {
            get { return new AsyncEnumerable<IStructWithSymbols, StructNode, IDocumentWithSymbols>(Structs); }
        }

        public Task AcceptAsync(ISymbolsVisitor visitor)
        {
            return AcceptAsync(new SymbolsNodeVisitor(visitor));
        }

        protected sealed override async Task<INodeFactory> GetNodeFactory(DocumentNode document)
        {
            return GetNodeFactory(await document.Document.GetSemanticModelAsync());
        }

        protected virtual INodeFactory GetNodeFactory(SemanticModel semanticModel)
        {
            return new SymbolNodeFactory(semanticModel);
        }
    }
}
