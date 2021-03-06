﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStructPropertyCollection<
        TProperty,
        TAutoProperty,
        TLambdaProperty,
        TExplicitInterfaceProperty> :
        AbstractGenericVisitableObject,
        IStructPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>
        where TProperty : IStructProperty
        where TAutoProperty : IStructAutoProperty
        where TLambdaProperty : IStructLambdaProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
        public int Count
        {
            get { return Properties.Count + ExplicitInterfaceProperties.Count; }
        }

        public abstract ICollection<TExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }

        public abstract ICollection<TProperty> Properties { get; set; }

        public abstract ICollection<TAutoProperty> AutoProperties { get; set; }

        public abstract ICollection<TLambdaProperty> LambdaProperties { get; set; }

        IReadOnlyCollection<TExplicitInterfaceProperty> IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>.ExplicitInterfaceProperties
        {
            get { return new ReadOnlyCollectionWrapper<TExplicitInterfaceProperty>(ExplicitInterfaceProperties); }
        }

        IReadOnlyCollection<TAutoProperty> IHasAutoProperties<TAutoProperty>.AutoProperties =>
            new ReadOnlyCollectionWrapper<TAutoProperty>(AutoProperties);

        IReadOnlyCollection<TLambdaProperty> IHasLambdaProperties<TLambdaProperty>.LambdaProperties =>
            new ReadOnlyCollectionWrapper<TLambdaProperty>(LambdaProperties);

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructPropertyCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
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
