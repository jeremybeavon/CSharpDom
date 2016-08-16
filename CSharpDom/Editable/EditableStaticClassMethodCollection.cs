using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStaticClassMethodCollection<TMethod, TExtensionMethod> :
        IStaticClassMethodCollection<TMethod, TExtensionMethod>
        where TMethod : IStaticClassMethod
        where TExtensionMethod : IExtensionMethod
    {
        public int Count
        {
            get { return Methods.Count + ExtensionMethods.Count; }
        }

        public virtual IReadOnlyCollection<TExtensionMethod> ExtensionMethods { get; set; }

        protected virtual IReadOnlyCollection<TMethod> Methods { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassMethodCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
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
