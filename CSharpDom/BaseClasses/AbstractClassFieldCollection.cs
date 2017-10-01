using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassFieldCollection<TField, TConstant> :
        AbstractGenericVisitableObject,
        IClassFieldCollection<TField, TConstant>
        where TField : IClassField
        where TConstant : IClassConstant
    {
        public abstract IReadOnlyCollection<TConstant> Constants { get; }

        public int Count
        {
            get { return Constants.Count + Fields.Count; }
        }

        protected abstract IReadOnlyCollection<TField> Fields { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassFieldCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
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
