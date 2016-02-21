using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassNestedInterfaceCollection :
        IStaticClassNestedInterfaceCollection<StaticClassNestedInterface, IPartialInterface>
    {
        public StaticClassNestedInterfaceCollection()
        {
            Interfaces = new List<StaticClassNestedInterface>();
        }

        public List<StaticClassNestedInterface> Interfaces { get; set; }

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
            visitor.VisitStaticClassNestedInterfaceCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassNestedInterfaceCollectionChildren(this, visitor);
        }

        public IEnumerator<StaticClassNestedInterface> GetEnumerator()
        {
            return Interfaces.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
