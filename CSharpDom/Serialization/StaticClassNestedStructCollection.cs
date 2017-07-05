using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassNestedStructCollection :
        IStaticClassNestedStructCollection<StaticClassNestedStruct, IStaticClassNestedPartialStruct>
    {
        public StaticClassNestedStructCollection()
        {
            Structs = new List<StaticClassNestedStruct>();
        }

        public List<StaticClassNestedStruct> Structs { get; set; }

        public int Count
        {
            get { return Structs.Count; }
        }

        public IReadOnlyCollection<IStaticClassNestedPartialStruct> PartialStructs
        {
            get { return new IStaticClassNestedPartialStruct[0]; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassNestedStructCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassNestedStructCollectionChildren(this, visitor);
        }

        public IEnumerator<StaticClassNestedStruct> GetEnumerator()
        {
            return Structs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
