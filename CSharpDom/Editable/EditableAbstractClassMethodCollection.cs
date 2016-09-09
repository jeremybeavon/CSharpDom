using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> :
        IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>
        where TMethod : IClassMethod
        where TAbstractMethod : IAbstractMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public abstract ICollection<TAbstractMethod> AbstractMethods { get; set; }

        public int Count
        {
            get { return Methods.Count + AbstractMethods.Count + ExplicitInterfaceMethods.Count; }
        }

        public abstract ICollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }

        public abstract ICollection<TMethod> Methods { get; set; }

        IReadOnlyCollection<TAbstractMethod> IHasAbstractMethods<TAbstractMethod>.AbstractMethods
        {
            get { return new ReadOnlyCollectionWrapper<TAbstractMethod>(AbstractMethods); }
        }

        IReadOnlyCollection<TExplicitInterfaceMethod> IHasExplicitInterfaceMethods<TExplicitInterfaceMethod>.ExplicitInterfaceMethods
        {
            get { return new ReadOnlyCollectionWrapper<TExplicitInterfaceMethod>(ExplicitInterfaceMethods); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClassMethodCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
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
