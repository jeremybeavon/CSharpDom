using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableClassFieldCollection<TField, TConstant> : IClassFieldCollection<TField, TConstant>
        where TField : IClassField
        where TConstant : IClassConstant
    {
        public abstract ICollection<TConstant> Constants { get; set; }

        public int Count
        {
            get { return Constants.Count + Fields.Count; }
        }

        public abstract ICollection<TField> Fields { get; set; }

        IReadOnlyCollection<TConstant> IHasConstants<TConstant>.Constants
        {
            get { return new ReadOnlyCollectionWrapper<TConstant>(Constants); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassFieldCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassFieldCollectionChildren(this, visitor);
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
