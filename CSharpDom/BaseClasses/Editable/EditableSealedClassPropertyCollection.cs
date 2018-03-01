﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableSealedClassPropertyCollection<
        TProperty,
        TAutoProperty,
        TLambdaProperty,
        TExplicitInterfaceProperty> :
        AbstractGenericVisitableObject,
        ISealedClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>
        where TProperty : ISealedClassProperty
        where TAutoProperty : ISealedClassAutoProperty
        where TLambdaProperty : ISealedClassLambdaProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
        public int Count
        {
            get { return Properties.Count + AutoProperties.Count + LambdaProperties.Count + ExplicitInterfaceProperties.Count; }
        }

        public abstract ICollection<TExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }

        public abstract ICollection<TProperty> Properties { get; set; }

        public abstract IReadOnlyCollection<TAutoProperty> AutoProperties { get; }

        public abstract IReadOnlyCollection<TLambdaProperty> LambdaProperties { get; }

        IReadOnlyCollection<TExplicitInterfaceProperty> IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>.ExplicitInterfaceProperties
        {
            get { return new ReadOnlyCollectionWrapper<TExplicitInterfaceProperty>(ExplicitInterfaceProperties); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassPropertyCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassPropertyCollectionChildren(this, visitor);
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
