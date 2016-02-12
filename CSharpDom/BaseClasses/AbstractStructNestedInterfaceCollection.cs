using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructNestedInterfaceCollection<TInterface, TPartialInterface> :
        IStructNestedInterfaceCollection<TInterface, TPartialInterface>
        where TInterface : IStructNestedInterface
        where TPartialInterface : IPartialInterface
    {
        public int Count
        {
            get { return PartialInterfaces.Count + Interfaces.Count; }
        }

        public abstract IReadOnlyCollection<TPartialInterface> PartialInterfaces { get; }

        protected abstract IReadOnlyCollection<TInterface> Interfaces { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructNestedInterfaceCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
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
