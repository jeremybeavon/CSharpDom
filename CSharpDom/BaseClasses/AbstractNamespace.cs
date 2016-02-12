using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection> :
        INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection>
        where TUsingDirective : IUsingDirective
        where TNamespace : INamespace
        where TClassCollection : IClassCollection
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterfaceCollection : IInterfaceCollection
        where TStructCollection : IStructCollection
    {
        public abstract TClassCollection Classes { get; }

        public abstract IReadOnlyCollection<TDelegate> Delegates { get; }

        public abstract IReadOnlyCollection<TEnum> Enums { get; }

        public abstract TInterfaceCollection Interfaces { get; }

        public abstract string Name { get; }

        public abstract IReadOnlyCollection<TNamespace> Namespaces { get; }

        public abstract TStructCollection Structs { get; }

        public abstract IReadOnlyCollection<TUsingDirective> UsingDirectives { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNamespace(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNamespaceChildren(this, visitor);
        }
    }
}
