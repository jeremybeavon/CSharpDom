using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableClassMethodCollection<TMethod, TExplicitInterfaceMethod> :
        IClassMethodCollection<TMethod, TExplicitInterfaceMethod>
        where TMethod : IClassMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public int Count
        {
            get { return Methods.Count + ExplicitInterfaceMethods.Count; }
        }

        public virtual ICollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }

        public virtual ICollection<TMethod> Methods { get; set; }

        IReadOnlyCollection<TExplicitInterfaceMethod> IHasExplicitInterfaceMethods<TExplicitInterfaceMethod>.ExplicitInterfaceMethods
        {
            get { return new ReadOnlyCollectionWrapper<TExplicitInterfaceMethod>(ExplicitInterfaceMethods); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassMethodCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
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
