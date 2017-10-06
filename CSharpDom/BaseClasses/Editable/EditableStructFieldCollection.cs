using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStructFieldCollection<TField, TConstant> :
        AbstractGenericVisitableObject,
        IStructFieldCollection<TField, TConstant>
        where TField : IStructField
        where TConstant : IStructConstant
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

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructFieldCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructFieldCollectionChildren(this, visitor);
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
