using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> :
        INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>
        where TUsingDirective : IUsingDirective
        where TNamespace : INamespace
        where TClassCollection : IClassCollection
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStructCollection : IStructCollection
    {
        public abstract TClassCollection Classes { get; set; }

        public abstract ICollection<TDelegate> Delegates { get; set; }

        public abstract ICollection<TEnum> Enums { get; set; }

        public abstract ICollection<TInterface> Interfaces { get; set; }

        public abstract string Name { get; set; }

        public abstract ICollection<TNamespace> Namespaces { get; set; }

        public abstract TStructCollection Structs { get; set; }

        public abstract ICollection<TUsingDirective> UsingDirectives { get; set; }

        IReadOnlyCollection<TDelegate> IHasDelegates<TDelegate>.Delegates
        {
            get { return new ReadOnlyCollectionWrapper<TDelegate>(Delegates); }
        }

        IReadOnlyCollection<TEnum> IHasEnums<TEnum>.Enums
        {
            get { return new ReadOnlyCollectionWrapper<TEnum>(Enums); }
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
