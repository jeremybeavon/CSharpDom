using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection> :
        INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection>
        where TUsingDirective : IUsingDirective
        where TNamespace : INamespace
        where TClassCollection : IClassCollection
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterfaceCollection : IInterfaceCollection
        where TStructCollection : IStructCollection
    {
        public virtual TClassCollection Classes { get; set; }

        public virtual IReadOnlyCollection<TDelegate> Delegates { get; set; }

        public virtual IReadOnlyCollection<TEnum> Enums { get; set; }

        public virtual TInterfaceCollection Interfaces { get; set; }

        public virtual string Name { get; set; }

        public virtual IReadOnlyCollection<TNamespace> Namespaces { get; set; }

        public virtual TStructCollection Structs { get; set; }

        public virtual IReadOnlyCollection<TUsingDirective> UsingDirectives { get; set; }

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
