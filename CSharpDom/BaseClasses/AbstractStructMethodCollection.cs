using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructMethodCollection<TMethod, TExplicitInterfaceMethod> :
        AbstractGenericVisitableObject,
        IStructMethodCollection<TMethod, TExplicitInterfaceMethod>
        where TMethod : IStructMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public int Count
        {
            get { return Methods.Count + ExplicitInterfaceMethods.Count; }
        }

        public abstract IReadOnlyCollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods { get; }

        protected abstract IReadOnlyCollection<TMethod> Methods { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructMethodCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructMethodCollectionChildren(this, visitor);
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
