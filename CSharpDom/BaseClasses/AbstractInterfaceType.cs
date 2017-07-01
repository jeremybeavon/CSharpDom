using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractInterfaceType<
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
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract IReadOnlyCollection<TEvent> Events { get; }

        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }

        public abstract IReadOnlyCollection<TIndexer> Indexers { get; }

        public abstract IReadOnlyCollection<TInterfaceReference> Interfaces { get; }

        public abstract IReadOnlyCollection<TMethod> Methods { get; }

        public abstract string Name { get; }

        public abstract IReadOnlyCollection<TProperty> Properties { get; }

        public abstract bool IsPartial { get; }
    }
}
