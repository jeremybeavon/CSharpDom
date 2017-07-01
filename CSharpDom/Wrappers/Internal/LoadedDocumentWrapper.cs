using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class LoadedDocumentWrapper : AbstractWrapper<ILoadedDocument>, ILoadedDocumentWrapper
    {
        private Func<IReadOnlyCollection<IAttributeGroupWrapper>> assemblyAttributes;
        private Func<IClassCollectionWrapper> classes;
        private Func<IReadOnlyCollection<IDelegateWrapper>> delegates;
        private Func<IDocumentWrapper> document;
        private Func<IReadOnlyCollection<IEnumWrapper>> enums;
        private Func<IInterfaceWrapper> interfaces;
        private Func<IReadOnlyCollection<IAttributeGroupWrapper>> moduleAttributes;
        private Func<IReadOnlyCollection<INamespaceWrapper>> namespaces;
        private Func<IProjectWrapper> project;
        private Func<ISolutionWrapper> solution;
        private Func<IStructCollectionWrapper> structs;
        private Func<IReadOnlyCollection<IUsingDirectiveWrapper>> usingDirectives;

        public LoadedDocumentWrapper(ILoadedDocument loadedDocument)
            : base(loadedDocument)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> AssemblyAttributes
        {
            get { return assemblyAttributes(); }
        }

        public IClassCollectionWrapper Classes
        {
            get { return classes(); }
        }

        public IReadOnlyCollection<IDelegateWrapper> Delegates
        {
            get { return delegates(); }
        }

        public IDocumentWrapper Document
        {
            get { return document(); }
        }

        public IReadOnlyCollection<IEnumWrapper> Enums
        {
            get { return enums(); }
        }

        public IInterfaceWrapper Interfaces
        {
            get { return interfaces(); }
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> ModuleAttributes
        {
            get { return moduleAttributes(); }
        }

        public IReadOnlyCollection<INamespaceWrapper> Namespaces
        {
            get { return namespaces(); }
        }

        public IProjectWrapper Project
        {
            get { return project(); }
        }

        public ISolutionWrapper Solution
        {
            get { return solution(); }
        }

        public IStructCollectionWrapper Structs
        {
            get { return structs(); }
        }

        public IReadOnlyCollection<IUsingDirectiveWrapper> UsingDirectives
        {
            get { return usingDirectives(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitLoadedDocument(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitLoadedDocumentChildren(this, visitor);
        }

        public override void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> loadedDocument)
        {
            assemblyAttributes = loadedDocument.AssemblyAttributes.WrapAttributes();
            classes = () => new ClassCollectionWrapper(loadedDocument.Classes);
            delegates = () => new ReadOnlyCollectionWrapper<TDelegate, IDelegateWrapper>(
                loadedDocument.Delegates,
                input => new DelegateWrapper(input));
            document = () => new DocumentWrapper(loadedDocument.Document);
            enums = () => new ReadOnlyCollectionWrapper<TEnum, IEnumWrapper>(
                loadedDocument.Enums,
                input => new EnumWrapper(input));
            //s\interfaces = () => new InterfaceCollectionWrapper(loadedDocument.Interfaces);
            moduleAttributes = loadedDocument.ModuleAttributes.WrapAttributes();
            namespaces = () => new ReadOnlyCollectionWrapper<TNamespace, INamespaceWrapper>(
                loadedDocument.Namespaces,
                input => new NamespaceWrapper(input));
            project = () => new ProjectWrapper(loadedDocument.Project);
            solution = () => new SolutionWrapper(loadedDocument.Solution);
            structs = () => new StructCollectionWrapper(loadedDocument.Structs);
            usingDirectives = () => new ReadOnlyCollectionWrapper<TUsingDirective, IUsingDirectiveWrapper>(
                loadedDocument.UsingDirectives,
                input => new UsingDirectiveWrapper(input));
        }
    }
}
