using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructFieldCollection<TField, TConstant> :
        AbstractGenericVisitableObject,
        IStructFieldCollection<TField, TConstant>
        where TField : IStructField
        where TConstant : IStructConstant
    {
        public abstract IReadOnlyCollection<TConstant> Constants { get; }

        public int Count
        {
            get { return Constants.Count + Fields.Count; }
        }

        protected abstract IReadOnlyCollection<TField> Fields { get; }

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
