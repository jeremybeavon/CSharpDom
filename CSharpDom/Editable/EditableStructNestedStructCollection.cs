using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Editable
{
    public class EditableStructNestedStructCollection<TStruct, TPartialStruct> :
        IStructNestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IStructNestedStruct
        where TPartialStruct : IPartialStruct
    {
        public int Count
        {
            get { return PartialStructs.Count + Structs.Count; }
        }

        public virtual IReadOnlyCollection<TPartialStruct> PartialStructs { get; set; }

        protected virtual IReadOnlyCollection<TStruct> Structs { get; set; }

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
