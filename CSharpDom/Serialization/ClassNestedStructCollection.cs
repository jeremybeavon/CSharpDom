using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Serialization
{
    public sealed class ClassNestedStructCollection : IClassNestedStructCollection<ClassNestedStruct, IPartialStruct>
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

        public IReadOnlyCollection<IPartialStruct> PartialStructs
        {
            get { return new IPartialStruct[0]; }
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
