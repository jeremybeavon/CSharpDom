using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassFieldCollection<TField, TConstant> : IStaticClassFieldCollection<TField, TConstant>
        where TField : IStaticClassField
        where TConstant : IStaticClassConstant
    {
        public abstract IReadOnlyCollection<TConstant> Constants { get; }

        public int Count
        {
            get { return Constants.Count + Fields.Count; }
        }

        protected abstract IReadOnlyCollection<TField> Fields { get; }

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
