using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractLoadedDocument<
        TSolution,
        TProject,
        TDocument,
        TUsingDirective,
        TAttributeGroup,
        TNamespace,
        TClassCollection,
        TDelegate,
        TEnum,
        TInterface,
        TStructCollection> :
        AbstractGenericVisitableObject,
        ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>
        where TSolution : ISolution
        where TProject : IProject
        where TDocument : IDocument
        where TUsingDirective : IUsingDirective
        where TAttributeGroup : IAttributeGroup
        where TNamespace : INamespace
        where TClassCollection : IClassCollection
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStructCollection : IStructCollection
    {
        public abstract IReadOnlyCollection<TAttributeGroup> AssemblyAttributes { get; }

        public abstract TClassCollection Classes { get; }

        public abstract IReadOnlyCollection<TDelegate> Delegates { get; }

        public abstract TDocument Document { get; }

        public abstract IReadOnlyCollection<TEnum> Enums { get; }

        public abstract IReadOnlyCollection<TInterface> Interfaces { get; }

        public abstract IReadOnlyCollection<TAttributeGroup> ModuleAttributes { get; }

        public abstract IReadOnlyCollection<TNamespace> Namespaces { get; }

        public abstract TProject Project { get; }

        public abstract TSolution Solution { get; }

        public abstract TStructCollection Structs { get; }

        public abstract IReadOnlyCollection<TUsingDirective> UsingDirectives { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitLoadedDocument(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitLoadedDocumentChildren(this, visitor);
        }
    }
}
