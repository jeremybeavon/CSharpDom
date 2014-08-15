using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.Internal;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class ProjectNodeWithLinqExpressions : ProjectNodeWithReflection, IProjectWithLinqExpressions
    {
        public ProjectNodeWithLinqExpressions(Project project, SolutionNode solution, IAssemblyLoader assemblyLoader)
            : base(project, solution, assemblyLoader)
        {
        }

        public IProjectWithReflection Reflection
        {
            get { return this; }
        }

        IAsyncEnumerable<IClassWithLinqExpressions, IDocumentWithLinqExpressions> ILinqExpressionContainer.Classes
        {
            get { return new AsyncEnumerable<IClassWithLinqExpressions, ClassNode, IDocumentWithLinqExpressions>(Classes); }
        }

        IAsyncEnumerable<IDelegateWithLinqExpressions, IDocumentWithLinqExpressions> ILinqExpressionContainer.Delegates
        {
            get { return new AsyncEnumerable<IDelegateWithLinqExpressions, DelegateNode, IDocumentWithLinqExpressions>(Delegates); }
        }

        IReadOnlyCollection<IDocumentWithLinqExpressions> IProject<IDocumentWithLinqExpressions>.Documents
        {
            get { return new ReadOnlyNodeCollection<IDocumentWithLinqExpressions, DocumentNode>(Documents); }
        }

        IAsyncEnumerable<IEnumWithLinqExpressions, IDocumentWithLinqExpressions> ILinqExpressionContainer.Enums
        {
            get { return new AsyncEnumerable<IEnumWithLinqExpressions, EnumNode, IDocumentWithLinqExpressions>(Enums); }
        }

        IAsyncEnumerable<IInterfaceWithLinqExpressions, IDocumentWithLinqExpressions> ILinqExpressionContainer.Interfaces
        {
            get { return new AsyncEnumerable<IInterfaceWithLinqExpressions, InterfaceNode, IDocumentWithLinqExpressions>(Interfaces); }
        }

        IAsyncEnumerable<INamespaceWithLinqExpressions, IDocumentWithLinqExpressions> ILinqExpressionContainer.Namespaces
        {
            get { return new AsyncEnumerable<INamespaceWithLinqExpressions, NamespaceNode, IDocumentWithLinqExpressions>(Namespaces); }
        }

        ISolutionWithLinqExpressions IHasSolution<ISolutionWithLinqExpressions>.Solution
        {
            get { return (ISolutionWithLinqExpressions)Solution; }
        }

        IAsyncEnumerable<IStructWithLinqExpressions, IDocumentWithLinqExpressions> ILinqExpressionContainer.Structs
        {
            get { return new AsyncEnumerable<IStructWithLinqExpressions, StructNode, IDocumentWithLinqExpressions>(Structs); }
        }

        protected override INodeFactory GetNodeFactory(SemanticModel semanticModel)
        {
            return new LinqExpressionNodeFactory(semanticModel);
        }
    }
}
