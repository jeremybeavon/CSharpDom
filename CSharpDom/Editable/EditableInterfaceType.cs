using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public class EditableInterfaceType<
        TAttributeGroup,
        TGenericParameter,
        TInterfaceReference,
        TEvent,
        TProperty,
        TIndexer,
        TMethod> :
        IInterfaceType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEvent : IInterfaceEvent
        where TProperty : IInterfaceProperty
        where TIndexer : IInterfaceIndexer
        where TMethod : IInterfaceMethod
    {
        public virtual ICollection<TAttributeGroup> Attributes { get; set; }

        public virtual ICollection<TEvent> Events { get; set; }

        public virtual IList<TGenericParameter> GenericParameters { get; set; }

        public virtual ICollection<TIndexer> Indexers { get; set; }

        public virtual IReadOnlyCollection<TInterfaceReference> Interfaces { get; set; }

        public virtual ICollection<TMethod> Methods { get; set; }

        public virtual string Name { get; set; }

        public virtual ICollection<TProperty> Properties { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyCollection<TEvent> IHasEvents<TEvent>.Events
        {
            get { return new ReadOnlyCollectionWrapper<TEvent>(Events); }
        }

        IReadOnlyList<TGenericParameter> IHasGenericParameters<TGenericParameter>.GenericParameters
        {
            get { return new ReadOnlyCollection<TGenericParameter>(GenericParameters); }
        }

        IReadOnlyCollection<TIndexer> IHasIndexers<TIndexer>.Indexers
        {
            get { return new ReadOnlyCollectionWrapper<TIndexer>(Indexers); }
        }

        IReadOnlyCollection<TMethod> IHasMethods<TMethod>.Methods
        {
            get { return new ReadOnlyCollectionWrapper<TMethod>(Methods); }
        }

        IReadOnlyCollection<TProperty> IHasProperties<TProperty>.Properties
        {
            get { return new ReadOnlyCollectionWrapper<TProperty>(Properties); }
        }
    }
}
