using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStaticClassFieldCollection<TField, TConstant> : IStaticClassFieldCollection<TField, TConstant>
        where TField : IStaticClassField
        where TConstant : IStaticClassConstant
    {
        public virtual IReadOnlyCollection<TConstant> Constants { get; set; }

        public int Count
        {
            get { return Constants.Count + Fields.Count; }
        }

        protected virtual IReadOnlyCollection<TField> Fields { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassFieldCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassFieldCollectionChildren(this, visitor);
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
