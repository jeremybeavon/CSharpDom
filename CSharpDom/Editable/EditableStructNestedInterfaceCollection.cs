using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableStructNestedInterfaceCollection<TInterface, TPartialInterface> :
        IStructNestedInterfaceCollection<TInterface, TPartialInterface>
        where TInterface : IStructNestedInterface
        where TPartialInterface : IPartialInterface
    {
        public int Count
        {
            get { return PartialInterfaces.Count + Interfaces.Count; }
        }

        public abstract ICollection<TPartialInterface> PartialInterfaces { get; set; }

        public abstract ICollection<TInterface> Interfaces { get; set; }

        IReadOnlyCollection<TPartialInterface> IHasPartialInterfaces<TPartialInterface>.PartialInterfaces
        {
            get { return new ReadOnlyCollectionWrapper<TPartialInterface>(PartialInterfaces); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructNestedInterfaceCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructNestedInterfaceCollectionChildren(this, visitor);
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
