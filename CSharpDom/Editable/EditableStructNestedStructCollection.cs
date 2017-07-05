using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableStructNestedStructCollection<TStruct, TPartialStruct> :
        IStructNestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IStructNestedStruct
        where TPartialStruct : IStructNestedPartialStruct
    {
        public int Count
        {
            get { return PartialStructs.Count + Structs.Count; }
        }

        public abstract ICollection<TPartialStruct> PartialStructs { get; set; }

        public abstract ICollection<TStruct> Structs { get; set; }

        IReadOnlyCollection<TPartialStruct> IHasPartialStructs<TPartialStruct>.PartialStructs
        {
            get { return new ReadOnlyCollectionWrapper<TPartialStruct>(PartialStructs); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructNestedStructCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructNestedStructCollectionChildren(this, visitor);
        }

        public IEnumerator<TStruct> GetEnumerator()
        {
            return Structs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
