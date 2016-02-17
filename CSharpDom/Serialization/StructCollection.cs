using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.Serialization
{
    public sealed class StructCollection : IStructCollection<Struct, PartialStructNotSupported>
    {
        public StructCollection()
        {
            Structs = new List<Struct>();
        }

        public List<Struct> Structs { get; set; }

        public int Count
        {
            get { return Structs.Count; }
        }

        public IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructCollectionChildren(this, visitor);
        }

        public IEnumerator<Struct> GetEnumerator()
        {
            return Structs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
