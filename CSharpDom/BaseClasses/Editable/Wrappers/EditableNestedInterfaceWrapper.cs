using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableNestedInterfaceWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> :
        EditableNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>,
        IWrapper<IEditableNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TInterfaceReference : IEditableInterfaceReference
        where TEvent : IEditableInterfaceEvent
        where TProperty : IEditableInterfaceProperty
        where TIndexer : IEditableInterfaceIndexer
        where TMethod : IEditableInterfaceMethod
    {
        public EditableNestedInterfaceWrapper(IEditableNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> nestedInterface)
        {
            WrappedObject = nestedInterface;
        }

        public override ICollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
            set { WrappedObject.Attributes = value; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
            set { WrappedObject.DeclaringType = value; }
        }

        public override ICollection<TEvent> Events
        {
            get { return WrappedObject.Events; }
            set { WrappedObject.Events = value; }
        }

        public override IList<TGenericParameter> GenericParameters
        {
            get { return WrappedObject.GenericParameters; }
            set { WrappedObject.GenericParameters = value; }
        }

        public override ICollection<TIndexer> Indexers
        {
            get { return WrappedObject.Indexers; }
            set { WrappedObject.Indexers = value; }
        }

        public override ICollection<TInterfaceReference> Interfaces
        {
            get { return WrappedObject.Interfaces; }
            set { WrappedObject.Interfaces = value; }
        }

        public override ICollection<TMethod> Methods
        {
            get { return WrappedObject.Methods; }
            set { WrappedObject.Methods = value; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
            set { WrappedObject.Name = value; }
        }

        public override ICollection<TProperty> Properties
        {
            get { return WrappedObject.Properties; }
            set { WrappedObject.Properties = value; }
        }

        public IEditableNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> WrappedObject { get; private set; }

        public override bool IsPartial
        {
            get => WrappedObject.IsPartial;
            set => WrappedObject.IsPartial = value;
        }
    }
}