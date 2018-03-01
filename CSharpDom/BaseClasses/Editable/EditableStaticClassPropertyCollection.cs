using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class AbstractStaticClassPropertyCollection<
        TProperty,
        TAutoProperty,
        TLambdaProperty> :
        EditableVisitableObject,
        IEditableStaticClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty>
        where TProperty : IEditableStaticClassProperty
        where TAutoProperty : IEditableStaticClassAutoProperty
        where TLambdaProperty : IEditableStaticClassLambdaProperty
    {
        public int Count
        {
            get { return Properties.Count + AutoProperties.Count + LambdaProperties.Count; }
        }

        public abstract ICollection<TAutoProperty> AutoProperties { get; set; }

        public abstract ICollection<TLambdaProperty> LambdaProperties { get; set; }

        public bool IsReadOnly => false;

        protected abstract ICollection<TProperty> Properties { get; set; }

        IReadOnlyCollection<TAutoProperty> IHasAutoProperties<TAutoProperty>.AutoProperties => throw new NotImplementedException();

        IReadOnlyCollection<TLambdaProperty> IHasLambdaProperties<TLambdaProperty>.LambdaProperties => throw new NotImplementedException();

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassPropertyCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
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
