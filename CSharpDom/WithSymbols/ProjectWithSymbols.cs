using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public sealed class ProjectWithSymbols : AbstractAsyncSymbolNode<IProjectWithSymbols>
    {
        private readonly IProjectWithSymbols project;

        private ProjectWithSymbols(IProjectWithSymbols project)
            : base(project)
        {
            this.project = project;
        }

        public IAsyncEnumerable<ClassWithSymbols, DocumentWithSymbols> Classes
        {
            get
            {
                return new AsyncEnumerableWithSymbols<ClassWithSymbols, IClassWithSymbols>(
                    project.Classes,
                    @class => new ClassWithSymbols(@class));
            }
        }

        public IAsyncEnumerable<DelegateWithSymbols, DocumentWithSymbols> Delegates
        {
            get
            {
                return new AsyncEnumerableWithSymbols<DelegateWithSymbols, IDelegateWithSymbols>(
                    project.Delegates,
                    @delegate => new DelegateWithSymbols(@delegate));
            }
        }

        public IReadOnlyCollection<DocumentWithSymbols> Documents
        {
            get
            {
                return new ReadOnlyNodeCollection<DocumentWithSymbols, IDocumentWithSymbols>(
                    project.Documents,
                    document => new DocumentWithSymbols(document));
            }
        }

        public IAsyncEnumerable<EnumWithSymbols, DocumentWithSymbols> Enums
        {
            get
            {
                return new AsyncEnumerableWithSymbols<EnumWithSymbols, IEnumWithSymbols>(
                    project.Enums,
                    @enum => new EnumWithSymbols(@enum));
            }
        }

        public IAsyncEnumerable<InterfaceWithSymbols, DocumentWithSymbols> Interfaces
        {
            get
            {
                return new AsyncEnumerableWithSymbols<InterfaceWithSymbols, IInterfaceWithSymbols>(
                    project.Interfaces,
                    @interface => new InterfaceWithSymbols(@interface));
            }
        }

        public IAsyncEnumerable<NamespaceWithSymbols, DocumentWithSymbols> Namespaces
        {
            get
            {
                return new AsyncEnumerableWithSymbols<NamespaceWithSymbols, INamespaceWithSymbols>(
                    project.Namespaces,
                    @namespace => new NamespaceWithSymbols(@namespace));
            }
        }

        public Project Project
        {
            get { return project.Project; }
        }

        public SolutionWithSymbols Solution
        {
            get { return SolutionWithSymbols.GetSolution(project.Solution); }
        }

        public IAsyncEnumerable<StructWithSymbols, DocumentWithSymbols> Structs
        {
            get
            {
                return new AsyncEnumerableWithSymbols<StructWithSymbols, IStructWithSymbols>(
                    project.Structs,
                    @struct => new StructWithSymbols(@struct));
            }
        }

        public static ProjectWithSymbols GetProject(IProjectWithSymbols project)
        {
            return project == null ? null : new ProjectWithSymbols(project);
        }

        public override Task AcceptAsync(SymbolsVisitor visitor)
        {
            return project.AcceptAsync(new SymbolsVisitorMapping(visitor));
        }
    }
}
