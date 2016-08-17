using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableInterfaceCollection<TInterface, TPartialInterface> :
        IInterfaceCollection<TInterface, TPartialInterface>
        where TInterface : IInterface
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

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceCollectionChildren(this, visitor);
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
