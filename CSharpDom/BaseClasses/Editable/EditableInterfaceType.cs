using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableInterfaceType<
        TAttributeGroup,
        TGenericParameter,
        TInterfaceReference,
        TEvent,
        TProperty,
        TIndexer,
        TMethod> :
        AbstractGenericVisitableObject,
        IInterfaceType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEvent : IInterfaceEvent
        where TProperty : IInterfaceProperty
        where TIndexer : IInterfaceIndexer
        where TMethod : IInterfaceMethod
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract ICollection<TEvent> Events { get; set; }

        public abstract IList<TGenericParameter> GenericParameters { get; set; }

        public abstract ICollection<TIndexer> Indexers { get; set; }

        public abstract ICollection<TInterfaceReference> Interfaces { get; set; }

        public abstract ICollection<TMethod> Methods { get; set; }

        public abstract string Name { get; set; }

        public abstract ICollection<TProperty> Properties { get; set; }

        public abstract bool IsPartial { get; set; }

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

        IReadOnlyCollection<TInterfaceReference> IHasInterfaces<TInterfaceReference>.Interfaces
        {
            get { return new ReadOnlyCollectionWrapper<TInterfaceReference>(Interfaces); }
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
