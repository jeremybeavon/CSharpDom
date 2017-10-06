using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> :
        AbstractGenericVisitableObject,
        IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>
        where TMethod : IClassMethod
        where TAbstractMethod : IAbstractMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public abstract ICollection<TAbstractMethod> AbstractMethods { get; set; }

        public virtual int Count
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
