using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty> :
        IAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty>
        where TProperty : IClassProperty
        where TAbstractProperty : IAbstractProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
        public abstract ICollection<TAbstractProperty> AbstractProperties { get; set; }

        public int Count
        {
            get { return Properties.Count + AbstractProperties.Count + ExplicitInterfaceProperties.Count; }
        }

        public abstract ICollection<TExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }

        public abstract ICollection<TProperty> Properties { get; set; }

        IReadOnlyCollection<TAbstractProperty> IHasAbstractProperties<TAbstractProperty>.AbstractProperties
        {
            get { return new ReadOnlyCollectionWrapper<TAbstractProperty>(AbstractProperties); }
        }

        IReadOnlyCollection<TExplicitInterfaceProperty> IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>.ExplicitInterfaceProperties
        {
            get { return new ReadOnlyCollectionWrapper<TExplicitInterfaceProperty>(ExplicitInterfaceProperties); }
        }

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
