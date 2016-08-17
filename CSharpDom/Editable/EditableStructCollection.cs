using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableStructCollection<TStruct, TPartialStruct> :
        IStructCollection<TStruct, TPartialStruct>
        where TStruct : IStruct
        where TPartialStruct : IPartialStruct
    {
        public int Count
        {
            get { return PartialStructs.Count + Structs.Count; }
        }

        public virtual ICollection<TPartialStruct> PartialStructs { get; set; }

        public virtual ICollection<TStruct> Structs { get; set; }

        IReadOnlyCollection<TPartialStruct> IHasPartialStructs<TPartialStruct>.PartialStructs
        {
            get { return new ReadOnlyCollectionWrapper<TPartialStruct>(PartialStructs); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructCollectionChildren(this, visitor);
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
