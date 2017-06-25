using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNestedStaticClassMethodCollection<TMethod> :
        INestedStaticClassMethodCollection<TMethod>
        where TMethod : IStaticClassMethod
    {
        public virtual int Count
        {
            get { return Methods.Count; }
        }

        protected abstract IReadOnlyCollection<TMethod> Methods { get; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedStaticClassMethodCollection(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedStaticClassMethodCollectionChildren(this, visitor);
        }

        public IEnumerator<TMethod> GetEnumerator()
        {
            return Methods.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
