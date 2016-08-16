using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty> :
        IAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty>
        where TProperty : IClassProperty
        where TAbstractProperty : IAbstractProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
        public virtual IReadOnlyCollection<TAbstractProperty> AbstractProperties { get; set; }

        public int Count
        {
            get { return Properties.Count + AbstractProperties.Count + ExplicitInterfaceProperties.Count; }
        }

        public virtual IReadOnlyCollection<TExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }

        protected virtual IReadOnlyCollection<TProperty> Properties { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClassPropertyCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractClassPropertyCollectionChildren(this, visitor);
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
