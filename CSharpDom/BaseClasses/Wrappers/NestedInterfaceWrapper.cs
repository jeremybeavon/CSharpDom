using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class NestedInterfaceWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> :
        AbstractNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>,
        IWrapper<INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEvent : IInterfaceEvent
        where TProperty : IInterfaceProperty
        where TIndexer : IInterfaceIndexer
        where TMethod : IInterfaceMethod
    {
        public NestedInterfaceWrapper(INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> nestedInterface)
        {
            WrappedObject = nestedInterface;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
        }

        public override IReadOnlyCollection<TEvent> Events
        {
            get { return WrappedObject.Events; }
        }

        public override IReadOnlyList<TGenericParameter> GenericParameters
        {
            get { return WrappedObject.GenericParameters; }
        }

        public override IReadOnlyCollection<TIndexer> Indexers
        {
            get { return WrappedObject.Indexers; }
        }

        public override IReadOnlyCollection<TInterfaceReference> Interfaces
        {
            get { return WrappedObject.Interfaces; }
        }

        public override IReadOnlyCollection<TMethod> Methods
        {
            get { return WrappedObject.Methods; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
        }

        public override IReadOnlyCollection<TProperty> Properties
        {
            get { return WrappedObject.Properties; }
        }

        public INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> WrappedObject { get; private set; }

        public override bool IsPartial => WrappedObject.IsPartial;
    }
}
