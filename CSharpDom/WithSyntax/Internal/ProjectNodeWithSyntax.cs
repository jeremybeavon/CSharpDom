using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSyntax.Internal
{
    internal class ProjectNodeWithSyntax : ProjectNode, IProjectSyntax
    {
        public ProjectNodeWithSyntax(Project project, SolutionNode solution)
            : base(project, solution)
        {
        }

        IAsyncEnumerable<IClassSyntax, IDocumentSyntax> ISyntaxContainer.Classes
        {
            get { return new AsyncEnumerable<IClassSyntax, ClassNode, IDocumentSyntax>(Classes); }
        }

        IAsyncEnumerable<IDelegateSyntax, IDocumentSyntax> ISyntaxContainer.Delegates
        {
            get { return new AsyncEnumerable<IDelegateSyntax, DelegateNode, IDocumentSyntax>(Delegates); }
        }

        IReadOnlyCollection<IDocumentSyntax> IProject<IDocumentSyntax>.Documents
        {
            get { return new ReadOnlyNodeCollection<IDocumentSyntax, DocumentNode>(Documents); }
        }

        IAsyncEnumerable<IEnumSyntax, IDocumentSyntax> ISyntaxContainer.Enums
        {
            get { return new AsyncEnumerable<IEnumSyntax, EnumNode, IDocumentSyntax>(Enums); }
        }

        IAsyncEnumerable<IInterfaceSyntax, IDocumentSyntax> ISyntaxContainer.Interfaces
        {
            get { return new AsyncEnumerable<IInterfaceSyntax, InterfaceNode, IDocumentSyntax>(Interfaces); }
        }

        IAsyncEnumerable<INamespaceSyntax, IDocumentSyntax> ISyntaxContainer.Namespaces
        {
            get { return new AsyncEnumerable<INamespaceSyntax, NamespaceNode, IDocumentSyntax>(Namespaces); }
        }

        ISolutionSyntax IHasSolution<ISolutionSyntax>.Solution
        {
            get { return (ISolutionSyntax)Solution; }
        }

        IAsyncEnumerable<IStructSyntax, IDocumentSyntax> ISyntaxContainer.Structs
        {
            get { return new AsyncEnumerable<IStructSyntax, StructNode, IDocumentSyntax>(Structs); }
        }

        public Task AcceptAsync(ISyntaxVisitor visitor)
        {
            return AcceptAsync(new SyntaxNodeVisitor(visitor));
        }
    }
}
