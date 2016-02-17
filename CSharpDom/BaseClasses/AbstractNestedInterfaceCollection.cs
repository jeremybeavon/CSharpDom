using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNestedInterfaceCollection<TInterface, TPartialInterface> :
        INestedInterfaceCollection<TInterface, TPartialInterface>
        where TInterface : INestedInterface
        where TPartialInterface : IPartialInterface
    {
        public int Count
        {
            get { return PartialInterfaces.Count + Interfaces.Count; }
        }

        public abstract IReadOnlyCollection<TPartialInterface> PartialInterfaces { get; }

        protected abstract IReadOnlyCollection<TInterface> Interfaces { get; }

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
