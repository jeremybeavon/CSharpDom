using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.Editable
{
    public abstract class EditableLoadedDocument<
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
        public abstract ICollection<TAttributeGroup> AssemblyAttributes { get; set; }

        public abstract TClassCollection Classes { get; set; }

        public abstract ICollection<TDelegate> Delegates { get; set; }

        public abstract TDocument Document { get; set; }

        public abstract ICollection<TEnum> Enums { get; set; }

        public abstract ICollection<TInterface> Interfaces { get; set; }

        public abstract ICollection<TAttributeGroup> ModuleAttributes { get; set; }

        public abstract ICollection<TNamespace> Namespaces { get; set; }

        public abstract TProject Project { get; set; }

        public abstract TSolution Solution { get; set; }

        public abstract TStructCollection Structs { get; set; }

        public abstract ICollection<TUsingDirective> UsingDirectives { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAssemblyAttributes<TAttributeGroup>.AssemblyAttributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(AssemblyAttributes); }
        }

        IReadOnlyCollection<TDelegate> IHasDelegates<TDelegate>.Delegates
        {
            get { return new ReadOnlyCollectionWrapper<TDelegate>(Delegates); }
        }

        IReadOnlyCollection<TEnum> IHasEnums<TEnum>.Enums
        {
            get { return new ReadOnlyCollectionWrapper<TEnum>(Enums); }
        }

        IReadOnlyCollection<TAttributeGroup> IHasModuleAttributes<TAttributeGroup>.ModuleAttributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(ModuleAttributes); }
        }

        IReadOnlyCollection<TNamespace> IHasNamespaces<TNamespace>.Namespaces
        {
            get { return new ReadOnlyCollectionWrapper<TNamespace>(Namespaces); }
        }

        IReadOnlyCollection<TUsingDirective> IHasUsingDirectives<TUsingDirective>.UsingDirectives
        {
            get { return new ReadOnlyCollectionWrapper<TUsingDirective>(UsingDirectives); }
        }

        IReadOnlyCollection<TInterface> IHasInterfaces<TInterface>.Interfaces =>
            new ReadOnlyCollectionWrapper<TInterface>(Interfaces);

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
