using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class StaticTypeWrapper<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> :
        AbstractStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>,
        IWrapper<IStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TEventCollection : IStaticClassEventCollection
        where TProperty : IStaticClassProperty
        where TMethodCollection : IStaticClassMethodCollection
        where TFieldCollection : IStaticClassFieldCollection
        where TNestedClassCollection : IStaticClassNestedClassCollection
        where TNestedDelegate : IStaticClassNestedDelegate
        where TNestedEnum : IStaticClassNestedEnum
        where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
        where TNestedStructCollection : IStaticClassNestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
        public StaticTypeWrapper(IStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> type)
        {
            WrappedObject = type;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }

        public override TNestedClassCollection Classes
        {
            get { return WrappedObject.Classes; }
        }

        public override IReadOnlyCollection<TNestedDelegate> Delegates
        {
            get { return WrappedObject.Delegates; }
        }

        public override IReadOnlyCollection<TNestedEnum> Enums
        {
            get { return WrappedObject.Enums; }
        }

        public override TEventCollection Events
        {
            get { return WrappedObject.Events; }
        }

        public override TFieldCollection Fields
        {
            get { return WrappedObject.Fields; }
        }

        public override IReadOnlyList<TGenericParameter> GenericParameters
        {
            get { return WrappedObject.GenericParameters; }
        }

        public override TNestedInterfaceCollection Interfaces
        {
            get { return WrappedObject.Interfaces; }
        }

        public override TMethodCollection Methods
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

        public override TStaticConstructor StaticConstructor
        {
            get { return WrappedObject.StaticConstructor; }
        }

        public override TNestedStructCollection Structs
        {
            get { return WrappedObject.Structs; }
        }

        public IStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> WrappedObject { get; private set; }
    }
}
