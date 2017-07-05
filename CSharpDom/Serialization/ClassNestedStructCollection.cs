using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Serialization
{
    public sealed class ClassNestedStructCollection : IClassNestedStructCollection<ClassNestedStruct, IClassNestedPartialStruct>
    {
        public ClassNestedStructCollection()
        {
            Structs = new List<ClassNestedStruct>();
        }

        public List<ClassNestedStruct> Structs { get; set; }

        public int Count
        {
            get { return Structs.Count; }
        }

        public IReadOnlyCollection<IClassNestedPartialStruct> PartialStructs
        {
            get { return new IClassNestedPartialStruct[0]; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedStructCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassNestedStructCollectionChildren(this, visitor);
        }

        public IEnumerator<ClassNestedStruct> GetEnumerator()
        {
            return Structs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
