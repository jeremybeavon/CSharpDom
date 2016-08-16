using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStructPropertyCollection<TProperty, TExplicitInterfaceProperty> :
        IStructPropertyCollection<TProperty, TExplicitInterfaceProperty>
        where TProperty : IStructProperty
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
            visitor.VisitStructPropertyCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructPropertyCollectionChildren(this, visitor);
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
