using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeAnalysis
{
    public sealed class LoadedProjectWithCodeAnalysis :
        AbstractLoadedProject<
            SolutionWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            NamespaceWithCodeAnalysis,
            ProjectClassCollectionWithCodeAnalysis,
            DelegateWithCodeAnalysis,
            EnumWithCodeAnalysis,
            InterfaceWithCodeAnalysis,
            ProjectStructCollectionWithCodeAnalysis>
    {
        private readonly ProjectWithCodeAnalysis project;
        private readonly IEnumerable<LoadedDocumentWithCodeAnalysis> documents;
        private readonly ProjectClassCollectionWithCodeAnalysis classes;
        private readonly IReadOnlyCollection<DelegateWithCodeAnalysis> delegates;
        private readonly IReadOnlyCollection<EnumWithCodeAnalysis> enums;
        private readonly IReadOnlyCollection<InterfaceWithCodeAnalysis> interfaces;
        private readonly IReadOnlyCollection<NamespaceWithCodeAnalysis> namespaces;
        private readonly ProjectStructCollectionWithCodeAnalysis structs;

        internal LoadedProjectWithCodeAnalysis(
            ProjectWithCodeAnalysis project,
            IEnumerable<LoadedDocumentWithCodeAnalysis> documents)
        {
            this.project = project;
            this.documents = documents;
            classes = new ProjectClassCollectionWithCodeAnalysis(this);
            delegates = Members(document => document.Delegates);
            enums = Members(document => document.Enums);
            interfaces = Members(document => document.Interfaces);
            namespaces = Members(document => document.Namespaces);
            structs = new ProjectStructCollectionWithCodeAnalysis(this);
        }

        public override ProjectClassCollectionWithCodeAnalysis Classes => classes;

        public override IReadOnlyCollection<DelegateWithCodeAnalysis> Delegates => delegates;

        public override IReadOnlyCollection<EnumWithCodeAnalysis> Enums => enums;

        public override IReadOnlyCollection<InterfaceWithCodeAnalysis> Interfaces => interfaces;

        public override IReadOnlyCollection<NamespaceWithCodeAnalysis> Namespaces => namespaces;

        public override ProjectWithCodeAnalysis Project => project;

        public override SolutionWithCodeAnalysis Solution => project.Solution;

        public override ProjectStructCollectionWithCodeAnalysis Structs => structs;

        internal IReadOnlyCollection<T> Members<T>(Func<LoadedDocumentWithCodeAnalysis, IEnumerable<T>> func)
        {
            return new LoadedProjectMemberCollection<T>(documents.SelectMany(func));
        }
    }
}
