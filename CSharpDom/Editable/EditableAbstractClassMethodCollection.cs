using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> :
        IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>
        where TMethod : IClassMethod
        where TAbstractMethod : IAbstractMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public virtual IReadOnlyCollection<TAbstractMethod> AbstractMethods { get; set; }

        public int Count
        {
            get { return Methods.Count + AbstractMethods.Count + ExplicitInterfaceMethods.Count; }
        }

        public virtual IReadOnlyCollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }

        protected virtual IReadOnlyCollection<TMethod> Methods { get; set; }

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
