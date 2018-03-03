using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableAbstractClassPropertyCollection<
        TProperty,
        TAutoProperty,
        TLambdaProperty,
        TAbstractProperty,
        TExplicitInterfaceProperty> :
        AbstractGenericVisitableObject,
        IAbstractClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TAbstractProperty, TExplicitInterfaceProperty>
        where TProperty : IClassProperty
        where TAutoProperty : IClassAutoProperty
        where TLambdaProperty : IClassLambdaProperty
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

        public abstract ICollection<TAutoProperty> AutoProperties { get; set; }

        public abstract ICollection<TLambdaProperty> LambdaProperties { get; set; }

        IReadOnlyCollection<TAbstractProperty> IHasAbstractProperties<TAbstractProperty>.AbstractProperties
        {
            get { return new ReadOnlyCollectionWrapper<TAbstractProperty>(AbstractProperties); }
        }

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
            visitor.VisitAbstractClassPropertyCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
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
