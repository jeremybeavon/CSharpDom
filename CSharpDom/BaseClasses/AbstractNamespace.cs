using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> :
        AbstractGenericVisitableObject,
        INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>
        where TUsingDirective : IUsingDirective
        where TNamespace : INamespace
        where TClassCollection : IClassCollection
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStructCollection : IStructCollection
    {
        public abstract TClassCollection Classes { get; }

        public abstract IReadOnlyCollection<TDelegate> Delegates { get; }

        public abstract IReadOnlyCollection<TEnum> Enums { get; }

        public abstract IReadOnlyCollection<TInterface> Interfaces { get; }

        public abstract string Name { get; }

        public abstract IReadOnlyCollection<TNamespace> Namespaces { get; }

        public abstract TStructCollection Structs { get; }

        public abstract IReadOnlyCollection<TUsingDirective> UsingDirectives { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNamespace(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNamespaceChildren(this, visitor);
        }
    }
}
