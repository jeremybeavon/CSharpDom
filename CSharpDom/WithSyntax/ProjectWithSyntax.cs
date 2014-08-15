using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSyntax
{
    public sealed class ProjectWithSyntax : AbstractAsyncSyntaxNode<IProjectSyntax>
    {
        private readonly IProjectSyntax project;

        private ProjectWithSyntax(IProjectSyntax project)
            : base(project)
        {
            this.project = project;
        }

        public IAsyncEnumerable<ClassWithSyntax, DocumentWithSyntax> Classes
        {
            get
            {
                return new AsyncEnumerableWithSyntax<ClassWithSyntax, IClassSyntax>(
                    project.Classes,
                    @class => new ClassWithSyntax(@class));
            }
        }

        public IAsyncEnumerable<DelegateWithSyntax, DocumentWithSyntax> Delegates
        {
            get
            {
                return new AsyncEnumerableWithSyntax<DelegateWithSyntax, IDelegateSyntax>(
                    project.Delegates,
                    @delegate => new DelegateWithSyntax(@delegate));
            }
        }

        public IReadOnlyCollection<DocumentWithSyntax> Documents
        {
            get
            {
                return new ReadOnlyNodeCollection<DocumentWithSyntax, IDocumentSyntax>(
                    project.Documents,
                    document => new DocumentWithSyntax(document));
            }
        }

        public IAsyncEnumerable<EnumWithSyntax, DocumentWithSyntax> Enums
        {
            get
            {
                return new AsyncEnumerableWithSyntax<EnumWithSyntax, IEnumSyntax>(
                    project.Enums,
                    @enum => new EnumWithSyntax(@enum));
            }
        }

        public IAsyncEnumerable<InterfaceWithSyntax, DocumentWithSyntax> Interfaces
        {
            get
            {
                return new AsyncEnumerableWithSyntax<InterfaceWithSyntax, IInterfaceSyntax>(
                    project.Interfaces,
                    @interface => new InterfaceWithSyntax(@interface));
            }
        }

        public IAsyncEnumerable<NamespaceWithSyntax, DocumentWithSyntax> Namespaces
        {
            get
            {
                return new AsyncEnumerableWithSyntax<NamespaceWithSyntax, INamespaceSyntax>(
                    project.Namespaces,
                    @namespace => new NamespaceWithSyntax(@namespace));
            }
        }

        public Project Project
        {
            get { return project.Project; }
        }

        public SolutionWithSyntax Solution
        {
            get { return SolutionWithSyntax.GetSolution(project.Solution); }
        }

        public IAsyncEnumerable<StructWithSyntax, DocumentWithSyntax> Structs
        {
            get
            {
                return new AsyncEnumerableWithSyntax<StructWithSyntax, IStructSyntax>(
                    project.Structs,
                    @struct => new StructWithSyntax(@struct));
            }
        }

        public static ProjectWithSyntax GetProject(IProjectSyntax project)
        {
            return project == null ? null : new ProjectWithSyntax(project);
        }

        public override Task AcceptAsync(SyntaxVisitor visitor)
        {
            return project.AcceptAsync(new SyntaxVisitorMapping(visitor));
        }
    }
}
