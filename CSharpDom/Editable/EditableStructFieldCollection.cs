using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableStructFieldCollection<TField, TConstant> : IStructFieldCollection<TField, TConstant>
        where TField : IStructField
        where TConstant : IStructConstant
    {
        public virtual ICollection<TConstant> Constants { get; set; }

        public int Count
        {
            get { return Constants.Count + Fields.Count; }
        }

        public virtual ICollection<TField> Fields { get; set; }

        IReadOnlyCollection<TConstant> IHasConstants<TConstant>.Constants
        {
            get { return new ReadOnlyCollectionWrapper<TConstant>(Constants); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructFieldCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            //GenericVisitor.VisitStructFieldCollectionChildren(this, visitor);
        }

        public IEnumerator<TField> GetEnumerator()
        {
            return Fields.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
