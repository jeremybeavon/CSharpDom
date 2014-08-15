using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.Internal;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection.Internal
{
    internal class ProjectNodeWithReflection : ProjectNodeWithSymbols, IProjectWithReflection
    {
        private readonly IAssemblyLoader assemblyLoader;
        private Assembly assembly;

        public ProjectNodeWithReflection(Project project, SolutionNode solution, IAssemblyLoader assemblyLoader)
            : base(project, solution)
        {
            this.assemblyLoader = assemblyLoader;
        }

        public Assembly Assembly
        {
            get { return assembly ?? (assembly = assemblyLoader.LoadAssembly(this)); }
        }

        public IProjectWithSymbols Symbols
        {
            get { return this; }
        }

        IAsyncEnumerable<IClassWithReflection, IDocumentWithReflection> IReflectionContainer.Classes
        {
            get { return new AsyncEnumerable<IClassWithReflection, ClassNode, IDocumentWithReflection>(Classes); }
        }

        IAsyncEnumerable<IDelegateWithReflection, IDocumentWithReflection> IReflectionContainer.Delegates
        {
            get { return new AsyncEnumerable<IDelegateWithReflection, DelegateNode, IDocumentWithReflection>(Delegates); }
        }

        IReadOnlyCollection<IDocumentWithReflection> IProject<IDocumentWithReflection>.Documents
        {
            get { return new ReadOnlyNodeCollection<IDocumentWithReflection, DocumentNode>(Documents); }
        }

        IAsyncEnumerable<IEnumWithReflection, IDocumentWithReflection> IReflectionContainer.Enums
        {
            get { return new AsyncEnumerable<IEnumWithReflection, EnumNode, IDocumentWithReflection>(Enums); }
        }

        IAsyncEnumerable<IInterfaceWithReflection, IDocumentWithReflection> IReflectionContainer.Interfaces
        {
            get { return new AsyncEnumerable<IInterfaceWithReflection, InterfaceNode, IDocumentWithReflection>(Interfaces); }
        }

        IAsyncEnumerable<INamespaceWithReflection, IDocumentWithReflection> IReflectionContainer.Namespaces
        {
            get { return new AsyncEnumerable<INamespaceWithReflection, NamespaceNode, IDocumentWithReflection>(Namespaces); }
        }

        ISolutionWithReflection IHasSolution<ISolutionWithReflection>.Solution
        {
            get { return (ISolutionWithReflection)Solution; }
        }

        IAsyncEnumerable<IStructWithReflection, IDocumentWithReflection> IReflectionContainer.Structs
        {
            get { return new AsyncEnumerable<IStructWithReflection, StructNode, IDocumentWithReflection>(Structs); }
        }

        public Task AcceptAsync(IReflectionVisitor visitor)
        {
            return AcceptAsync(new ReflectionNodeVisitor(visitor));
        }

        protected override INodeFactory GetNodeFactory(SemanticModel semanticModel)
        {
            return new ReflectionNodeFactory(semanticModel);
        }
    }
}
