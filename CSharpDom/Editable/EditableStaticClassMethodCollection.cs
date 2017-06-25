using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableStaticClassMethodCollection<TMethod, TExtensionMethod> :
        IStaticClassMethodCollection<TMethod, TExtensionMethod>
        where TMethod : IStaticClassMethod
        where TExtensionMethod : IExtensionMethod
    {
        public int Count
        {
            get { return Methods.Count + ExtensionMethods.Count; }
        }

        public abstract ICollection<TExtensionMethod> ExtensionMethods { get; set; }

        public abstract ICollection<TMethod> Methods { get; set; }

        IReadOnlyCollection<TExtensionMethod> IHasExtensionMethods<TExtensionMethod>.ExtensionMethods
        {
            get { return new ReadOnlyCollectionWrapper<TExtensionMethod>(ExtensionMethods); }
        }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassMethodCollection(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassMethodCollectionChildren(this, visitor);
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
