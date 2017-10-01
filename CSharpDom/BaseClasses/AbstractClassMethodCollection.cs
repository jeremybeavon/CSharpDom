using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassMethodCollection<TMethod, TExplicitInterfaceMethod> :
        AbstractGenericVisitableObject,
        IClassMethodCollection<TMethod, TExplicitInterfaceMethod>
        where TMethod : IClassMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public virtual int Count
        {
            get { return Methods.Count + ExplicitInterfaceMethods.Count; }
        }

        public abstract IReadOnlyCollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods { get; }

        protected abstract IReadOnlyCollection<TMethod> Methods { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassMethodCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassMethodCollectionChildren(this, visitor);
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
