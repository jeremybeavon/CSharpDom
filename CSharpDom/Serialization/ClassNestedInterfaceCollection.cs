using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Serialization
{
    public sealed class ClassNestedInterfaceCollection : IClassNestedInterfaceCollection<ClassNestedInterface, IPartialInterface>
    {
        public ClassNestedInterfaceCollection()
        {
            Interfaces = new List<ClassNestedInterface>();
        }

        public List<ClassNestedInterface> Interfaces { get; set; }

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
            visitor.VisitClassNestedInterfaceCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassNestedInterfaceCollectionChildren(this, visitor);
        }

        public IEnumerator<ClassNestedInterface> GetEnumerator()
        {
            return Interfaces.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
