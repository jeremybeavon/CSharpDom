using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Wrappers.Internal;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableClassPropertyCollection<
        TProperty,
        TAutoProperty,
        TLambdaProperty,
        TExplicitInterfaceProperty> :
        EditableVisitableObject,
        IEditableClassPropertyCollection<TProperty,TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>
        where TProperty : IEditableClassProperty
        where TAutoProperty : IEditableClassAutoProperty
        where TLambdaProperty : IEditableClassLambdaProperty
        where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty
    {
        public int Count
        {
            get { return Properties.Count + ExplicitInterfaceProperties.Count; }
        }

        public abstract ICollection<TExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }

        public abstract ICollection<TProperty> Properties { get; set; }

        public abstract IReadOnlyCollection<TAutoProperty> AutoProperties { get; }

        public abstract IReadOnlyCollection<TLambdaProperty> LambdaProperties { get; }

        public bool IsReadOnly => Properties.IsReadOnly;

        IReadOnlyCollection<TExplicitInterfaceProperty> IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>.ExplicitInterfaceProperties
        {
            get { return new ReadOnlyCollectionWrapper<TExplicitInterfaceProperty>(ExplicitInterfaceProperties); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassPropertyCollection(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            throw new System.NotImplementedException();
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassPropertyCollectionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            throw new System.NotImplementedException();
        }

        public void Add(TProperty item)
        {
            Properties.Add(item);
        }

        public void Clear()
        {
            Properties.Clear();
        }

        public bool Contains(TProperty item)
        {
            return Properties.Contains(item);
        }

        public void CopyTo(TProperty[] array, int arrayIndex)
        {
            Properties.CopyTo(array, arrayIndex);
        }

        public IEnumerator<TProperty> GetEnumerator()
        {
            return Properties.GetEnumerator();
        }

        public bool Remove(TProperty item)
        {
            return Properties.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
