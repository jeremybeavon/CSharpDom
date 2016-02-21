using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Serialization
{
    public sealed class StructNestedInterfaceCollection :
        IStructNestedInterfaceCollection<StructNestedInterface, IPartialInterface>
    {
        public StructNestedInterfaceCollection()
        {
            Interfaces = new List<StructNestedInterface>();
        }

        public List<StructNestedInterface> Interfaces { get; set; }

        public int Count
        {
            get { return Interfaces.Count; }
        }

        public IReadOnlyCollection<IPartialInterface> PartialInterfaces
        {
            get { return new IPartialInterface[0]; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructNestedInterfaceCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructNestedInterfaceCollectionChildren(this, visitor);
        }

        public IEnumerator<StructNestedInterface> GetEnumerator()
        {
            return Interfaces.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
