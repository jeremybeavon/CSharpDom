using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public sealed class ProjectWithReflection
    {
        private readonly IProjectWithReflection project;

        private ProjectWithReflection(IProjectWithReflection project)
        {
            this.project = project;
        }

        public IAsyncEnumerable<ClassWithReflection, DocumentWithReflection> Classes
        {
            get
            {
                return new AsyncEnumerableWithReflection<ClassWithReflection, IClassWithReflection>(
                    project.Classes,
                    @class => new ClassWithReflection(@class));
            }
        }

        public IAsyncEnumerable<DelegateWithReflection, DocumentWithReflection> Delegates
        {
            get
            {
                return new AsyncEnumerableWithReflection<DelegateWithReflection, IDelegateWithReflection>(
                    project.Delegates,
                    @delegate => new DelegateWithReflection(@delegate));
            }
        }

        public IReadOnlyCollection<DocumentWithReflection> Documents
        {
            get
            {
                return new ReadOnlyNodeCollection<DocumentWithReflection, IDocumentWithReflection>(
                    project.Documents,
                    document => new DocumentWithReflection(document));
            }
        }

        public IAsyncEnumerable<EnumWithReflection, DocumentWithReflection> Enums
        {
            get
            {
                return new AsyncEnumerableWithReflection<EnumWithReflection, IEnumWithReflection>(
                    project.Enums,
                    @enum => new EnumWithReflection(@enum));
            }
        }

        public IAsyncEnumerable<InterfaceWithReflection, DocumentWithReflection> Interfaces
        {
            get
            {
                return new AsyncEnumerableWithReflection<InterfaceWithReflection, IInterfaceWithReflection>(
                    project.Interfaces,
                    @interface => new InterfaceWithReflection(@interface));
            }
        }

        public IAsyncEnumerable<NamespaceWithReflection, DocumentWithReflection> Namespaces
        {
            get
            {
                return new AsyncEnumerableWithReflection<NamespaceWithReflection, INamespaceWithReflection>(
                    project.Namespaces,
                    @namespace => new NamespaceWithReflection(@namespace));
            }
        }

        public Project Project
        {
            get { return project.Project; }
        }

        public SolutionWithReflection Solution
        {
            get { return SolutionWithReflection.GetSolution(project.Solution); }
        }

        public IAsyncEnumerable<StructWithReflection, DocumentWithReflection> Structs
        {
            get
            {
                return new AsyncEnumerableWithReflection<StructWithReflection, IStructWithReflection>(
                    project.Structs,
                    @struct => new StructWithReflection(@struct));
            }
        }

        public static ProjectWithReflection GetProject(IProjectWithReflection project)
        {
            return project == null ? null : new ProjectWithReflection(project);
        }

        public Task AcceptAsync(ReflectionVisitor visitor)
        {
            return project.AcceptAsync(new ReflectionVisitorMapping(visitor));
        }
    }
}
