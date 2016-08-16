using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Editable
{
    public class EditableNestedStructCollection<TStruct, TPartialStruct> :
        INestedStructCollection<TStruct, TPartialStruct>
        where TStruct : INestedStruct
        where TPartialStruct : IPartialStruct
    {
        public int Count
        {
            get { return PartialStructs.Count + Structs.Count; }
        }

        public virtual IReadOnlyCollection<TPartialStruct> PartialStructs { get; set; }

        protected virtual IReadOnlyCollection<TStruct> Structs { get; set; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedStructCollection(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedStructCollectionChildren(this, visitor);
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
