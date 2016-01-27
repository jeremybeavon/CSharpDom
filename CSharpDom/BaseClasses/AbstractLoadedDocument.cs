using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractLoadedDocument<TSolution, TProject, TDocument, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> :
        ILoadedDocument<TSolution, TProject, TDocument, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>
        where TSolution : ISolution
        where TProject : IProject
        where TDocument : IDocument
        where TNamespace : INamespace
        where TClass : IClass
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStruct : IStruct
    {
        public abstract IReadOnlyCollection<TClass> Classes { get; }

        public abstract IReadOnlyCollection<TDelegate> Delegates { get; }

        public abstract TDocument Document { get; }

        public abstract IReadOnlyCollection<TEnum> Enums { get; }

        public abstract IReadOnlyCollection<TInterface> Interfaces { get; }

        public abstract IReadOnlyCollection<TNamespace> Namespaces { get; }

        public abstract TProject Project { get; }

        public abstract TSolution Solution { get; }

        public abstract IReadOnlyCollection<TStruct> Structs { get; }

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
