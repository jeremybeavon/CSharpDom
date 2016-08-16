using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableLoadedDocument<
        TSolution,
        TProject,
        TDocument,
        TUsingDirective,
        TAttributeGroup,
        TNamespace,
        TClassCollection,
        TDelegate,
        TEnum,
        TInterfaceCollection,
        TStructCollection> :
        ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection>
        where TSolution : ISolution
        where TProject : IProject
        where TDocument : IDocument
        where TUsingDirective : IUsingDirective
        where TAttributeGroup : IAttributeGroup
        where TNamespace : INamespace
        where TClassCollection : IClassCollection
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterfaceCollection : IInterfaceCollection
        where TStructCollection : IStructCollection
    {
        public virtual IReadOnlyCollection<TAttributeGroup> AssemblyAttributes { get; set; }

        public virtual TClassCollection Classes { get; set; }

        public virtual IReadOnlyCollection<TDelegate> Delegates { get; set; }

        public virtual TDocument Document { get; set; }

        public virtual IReadOnlyCollection<TEnum> Enums { get; set; }

        public virtual TInterfaceCollection Interfaces { get; set; }

        public virtual IReadOnlyCollection<TAttributeGroup> ModuleAttributes { get; set; }

        public virtual IReadOnlyCollection<TNamespace> Namespaces { get; set; }

        public virtual TProject Project { get; set; }

        public virtual TSolution Solution { get; set; }

        public virtual TStructCollection Structs { get; set; }

        public virtual IReadOnlyCollection<TUsingDirective> UsingDirectives { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitLoadedDocument(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitLoadedDocumentChildren(this, visitor);
        }
    }
}
