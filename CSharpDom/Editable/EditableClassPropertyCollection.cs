using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableClassPropertyCollection<TProperty, TExplicitInterfaceProperty> :
        IClassPropertyCollection<TProperty, TExplicitInterfaceProperty>
        where TProperty : IClassProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
        public int Count
        {
            get { return Properties.Count + ExplicitInterfaceProperties.Count; }
        }

        public virtual IReadOnlyCollection<TExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }

        protected virtual IReadOnlyCollection<TProperty> Properties { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassPropertyCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassPropertyCollectionChildren(this, visitor);
        }

        public IEnumerator<TProperty> GetEnumerator()
        {
            return Properties.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
