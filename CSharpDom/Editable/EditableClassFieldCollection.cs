using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableClassFieldCollection<TField, TConstant> : IClassFieldCollection<TField, TConstant>
        where TField : IClassField
        where TConstant : IClassConstant
    {
        public virtual IReadOnlyCollection<TConstant> Constants { get; set; }

        public int Count
        {
            get { return Constants.Count + Fields.Count; }
        }

        protected virtual IReadOnlyCollection<TField> Fields { get; set; }

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
