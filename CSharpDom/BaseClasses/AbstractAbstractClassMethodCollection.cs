using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> :
        AbstractGenericVisitableObject,
        IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>
        where TMethod : IClassMethod
        where TAbstractMethod : IAbstractMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public abstract IReadOnlyCollection<TAbstractMethod> AbstractMethods { get; }

        public virtual int Count
        {
            get { return Methods.Count + AbstractMethods.Count + ExplicitInterfaceMethods.Count; }
        }

        public abstract IReadOnlyCollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods { get; }

        protected abstract IReadOnlyCollection<TMethod> Methods { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClassMethodCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractClassMethodCollectionChildren(this, visitor);
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
