using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class NestedStaticClassMethodCollection : INestedStaticClassMethodCollection<StaticClassMethod>
    {
        public NestedStaticClassMethodCollection()
        {
            Methods = new List<StaticClassMethod>();
        }

        public List<StaticClassMethod> Methods { get; set; }

        public int Count
        {
            get { return Methods.Count; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedStaticClassMethodCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedStaticClassMethodCollectionChildren(this, visitor);
        }

        public IEnumerator<StaticClassMethod> GetEnumerator()
        {
            return Methods.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
