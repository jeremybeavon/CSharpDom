using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableNestedInterfaceCollection<TInterface, TPartialInterface> :
        INestedInterfaceCollection<TInterface, TPartialInterface>
        where TInterface : INestedInterface
        where TPartialInterface : IPartialInterface
    {
        public int Count
        {
            get { return PartialInterfaces.Count + Interfaces.Count; }
        }

        public virtual ICollection<TPartialInterface> PartialInterfaces { get; set; }

        public virtual ICollection<TInterface> Interfaces { get; set; }

        IReadOnlyCollection<TPartialInterface> IHasPartialInterfaces<TPartialInterface>.PartialInterfaces
        {
            get { return new ReadOnlyCollectionWrapper<TPartialInterface>(PartialInterfaces); }
        }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedInterfaceCollection(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedInterfaceCollectionChildren(this, visitor);
        }

        public IEnumerator<TInterface> GetEnumerator()
        {
            return Interfaces.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
