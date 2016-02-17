using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.Serialization
{
    public sealed class InterfaceCollection : IInterfaceCollection<Interface, PartialInterfaceNotSupported>
    {
        public InterfaceCollection()
        {
            Interfaces = new List<Interface>();
        }

        public List<Interface> Interfaces { get; set; }

        public int Count
        {
            get { return Interfaces.Count; }
        }

        public IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceCollectionChildren(this, visitor);
        }

        public IEnumerator<Interface> GetEnumerator()
        {
            return Interfaces.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
