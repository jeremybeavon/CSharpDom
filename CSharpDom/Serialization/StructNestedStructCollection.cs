using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Serialization
{
    public sealed class StructNestedStructCollection :
        IStructNestedStructCollection<StructNestedStruct, IPartialStruct>
    {
        public StructNestedStructCollection()
        {
            Structs = new List<StructNestedStruct>();
        }

        public List<StructNestedStruct> Structs { get; set; }

        public int Count
        {
            get { return Structs.Count; }
        }

        public IReadOnlyCollection<IPartialStruct> PartialStructs
        {
            get { return new IPartialStruct[0]; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructNestedStructCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructNestedStructCollectionChildren(this, visitor);
        }

        public IEnumerator<StructNestedStruct> GetEnumerator()
        {
            return Structs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
