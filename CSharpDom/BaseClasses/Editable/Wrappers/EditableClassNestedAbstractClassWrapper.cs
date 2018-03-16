using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableClassNestedAbstractClassWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> :
        EditableClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>,
        IWrapper<IEditableClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TClassReference : IEditableClassReference
        where TInterfaceReference : IEditableInterfaceReference
        where TEventCollection : IEditableAbstractClassEventCollection
        where TPropertyCollection : IEditableAbstractClassPropertyCollection
        where TIndexerCollection : IEditableAbstractClassIndexerCollection
        where TMethodCollection : IEditableAbstractClassMethodCollection
        where TFieldCollection : IEditableClassFieldCollection
        where TConstructor : IEditableClassConstructor
        where TOperatorOverload : IEditableOperatorOverload
        where TConversionOperator : IEditableConversionOperator
        where TNestedClassCollection : IEditableClassNestedClassCollection
        where TNestedDelegate : IEditableClassNestedDelegate
        where TNestedEnum : IEditableClassNestedEnum
        where TNestedInterface : IEditableClassNestedInterface
        where TNestedStructCollection : IEditableClassNestedStructCollection
        where TStaticConstructor : IEditableStaticConstructor
        where TDestructor : IEditableDestructor
    {
        public EditableClassNestedAbstractClassWrapper(IEditableClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            WrappedObject = @class;
        }

        public override ICollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
            set { WrappedObject.Attributes = value; }
        }

        public override TClassReference BaseClass
        {
            get { return WrappedObject.BaseClass; }
            set { WrappedObject.BaseClass = value; }
        }

        public override TNestedClassCollection Classes
        {
            get { return WrappedObject.Classes; }
            set { WrappedObject.Classes = value; }
        }

        public override ICollection<TConstructor> Constructors
        {
            get { return WrappedObject.Constructors; }
            set { WrappedObject.Constructors = value; }
        }

        public override ICollection<TConversionOperator> ConversionOperators
        {
            get { return WrappedObject.ConversionOperators; }
            set { WrappedObject.ConversionOperators = value; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
            set { WrappedObject.DeclaringType = value; }
        }

        public override ICollection<TNestedDelegate> Delegates
        {
            get { return WrappedObject.Delegates; }
            set { WrappedObject.Delegates = value; }
        }

        public override TDestructor Destructor
        {
            get { return WrappedObject.Destructor; }
            set { WrappedObject.Destructor = value; }
        }

        public override ICollection<TNestedEnum> Enums
        {
            get { return WrappedObject.Enums; }
            set { WrappedObject.Enums = value; }
        }

        public override TEventCollection Events
        {
            get { return WrappedObject.Events; }
            set { WrappedObject.Events = value; }
        }

        public override TFieldCollection Fields
        {
            get { return WrappedObject.Fields; }
            set { WrappedObject.Fields = value; }
        }

        public override IList<TGenericParameter> GenericParameters
        {
            get { return WrappedObject.GenericParameters; }
            set { WrappedObject.GenericParameters = value; }
        }

        public override ICollection<TInterfaceReference> ImplementedInterfaces
        {
            get { return WrappedObject.ImplementedInterfaces; }
            set { WrappedObject.ImplementedInterfaces = value; }
        }

        public override TIndexerCollection Indexers
        {
            get { return WrappedObject.Indexers; }
            set { WrappedObject.Indexers = value; }
        }

        public override ICollection<TNestedInterface> Interfaces
        {
            get { return WrappedObject.Interfaces; }
            set { WrappedObject.Interfaces = value; }
        }

        public override TMethodCollection Methods
        {
            get { return WrappedObject.Methods; }
            set { WrappedObject.Methods = value; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
            set { WrappedObject.Name = value; }
        }

        public override ICollection<TOperatorOverload> OperatorOverloads
        {
            get { return WrappedObject.OperatorOverloads; }
            set { WrappedObject.OperatorOverloads = value; }
        }

        public override TPropertyCollection Properties
        {
            get { return WrappedObject.Properties; }
            set { WrappedObject.Properties = value; }
        }

        public override TStaticConstructor StaticConstructor
        {
            get { return WrappedObject.StaticConstructor; }
            set { WrappedObject.StaticConstructor = value; }
        }

        public override TNestedStructCollection Structs
        {
            get { return WrappedObject.Structs; }
            set { WrappedObject.Structs = value; }
        }

        public IEditableClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> WrappedObject { get; private set; }

        public override ClassMemberVisibilityModifier Visibility => WrappedObject.Visibility;
    }
}