using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

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

        public virtual IReadOnlyCollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }

        protected virtual IReadOnlyCollection<TMethod> Methods { get; set; }

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
