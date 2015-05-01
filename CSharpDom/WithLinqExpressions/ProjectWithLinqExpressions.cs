using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class ProjectWithLinqExpressions
    {
        private readonly IProjectWithLinqExpressions project;

        private ProjectWithLinqExpressions(IProjectWithLinqExpressions project)
        {
            this.project = project;
        }

        public IAsyncEnumerable<ClassWithLinqExpressions, DocumentWithLinqExpressions> Classes
        {
            get
            {
                return new AsyncEnumerableWithLinqExpressions<ClassWithLinqExpressions, IClassWithLinqExpressions>(
                    project.Classes,
                    @class => new ClassWithLinqExpressions(@class));
            }
        }

        public IAsyncEnumerable<DelegateWithLinqExpressions, DocumentWithLinqExpressions> Delegates
        {
            get
            {
                return new AsyncEnumerableWithLinqExpressions<DelegateWithLinqExpressions, IDelegateWithLinqExpressions>(
                    project.Delegates,
                    @delegate => new DelegateWithLinqExpressions(@delegate));
            }
        }

        public IReadOnlyCollection<DocumentWithLinqExpressions> Documents
        {
            get
            {
                return new ReadOnlyNodeCollection<DocumentWithLinqExpressions, IDocumentWithLinqExpressions>(
                    project.Documents,
                    document => new DocumentWithLinqExpressions(document));
            }
        }

        public IAsyncEnumerable<EnumWithLinqExpressions, DocumentWithLinqExpressions> Enums
        {
            get
            {
                return new AsyncEnumerableWithLinqExpressions<EnumWithLinqExpressions, IEnumWithLinqExpressions>(
                    project.Enums,
                    @enum => new EnumWithLinqExpressions(@enum));
            }
        }

        public IAsyncEnumerable<InterfaceWithLinqExpressions, DocumentWithLinqExpressions> Interfaces
        {
            get
            {
                return new AsyncEnumerableWithLinqExpressions<InterfaceWithLinqExpressions, IInterfaceWithLinqExpressions>(
                    project.Interfaces,
                    @interface => new InterfaceWithLinqExpressions(@interface));
            }
        }

        public IAsyncEnumerable<NamespaceWithLinqExpressions, DocumentWithLinqExpressions> Namespaces
        {
            get
            {
                return new AsyncEnumerableWithLinqExpressions<NamespaceWithLinqExpressions, INamespaceWithLinqExpressions>(
                    project.Namespaces,
                    @namespace => new NamespaceWithLinqExpressions(@namespace));
            }
        }

        public Project Project
        {
            get { return project.Project; }
        }

        public SolutionWithLinqExpressions Solution
        {
            get { return SolutionWithLinqExpressions.GetSolution(project.Solution); }
        }

        public IAsyncEnumerable<StructWithLinqExpressions, DocumentWithLinqExpressions> Structs
        {
            get
            {
                return new AsyncEnumerableWithLinqExpressions<StructWithLinqExpressions, IStructWithLinqExpressions>(
                    project.Structs,
                    @struct => new StructWithLinqExpressions(@struct));
            }
        }

        public static ProjectWithLinqExpressions GetProject(IProjectWithLinqExpressions project)
        {
            return project == null ? null : new ProjectWithLinqExpressions(project);
        }

        public Task AcceptAsync(LinqExpressionsVisitor visitor)
        {
            return project.AcceptAsync(new LinqExpressionsVisitorMapping(visitor));
        }
    }
}
