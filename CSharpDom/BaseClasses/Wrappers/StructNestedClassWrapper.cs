﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class StructNestedClassWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> :
        AbstractStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>,
        IWrapper<IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TGenericParameter : IGenericParameterDeclaration
        where TClassReference : IClassReference
        where TInterfaceReference : IInterfaceReference
        where TEventCollection : IClassEventCollection
        where TPropertyCollection : IClassPropertyCollection
        where TIndexerCollection : IClassIndexerCollection
        where TMethodCollection : IClassMethodCollection
        where TFieldCollection : IClassFieldCollection
        where TConstructor : IClassConstructor
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClassCollection : IClassNestedClassCollection
        where TNestedDelegate : IClassNestedDelegate
        where TNestedEnum : IClassNestedEnum
        where TNestedInterface : IClassNestedInterface
        where TNestedStructCollection : IClassNestedStructCollection
        where TStaticConstructor : IStaticConstructor
        where TDestructor : IDestructor
    {
        public StructNestedClassWrapper(IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            WrappedObject = @class;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }

        public override TClassReference BaseClass
        {
            get { return WrappedObject.BaseClass; }
        }

        public override TNestedClassCollection Classes
        {
            get { return WrappedObject.Classes; }
        }

        public override IReadOnlyCollection<TConstructor> Constructors
        {
            get { return WrappedObject.Constructors; }
        }

        public override IReadOnlyCollection<TConversionOperator> ConversionOperators
        {
            get { return WrappedObject.ConversionOperators; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
        }

        public override IReadOnlyCollection<TNestedDelegate> Delegates
        {
            get { return WrappedObject.Delegates; }
        }

        public override TDestructor Destructor
        {
            get { return WrappedObject.Destructor; }
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

        public override IReadOnlyCollection<TInterfaceReference> ImplementedInterfaces
        {
            get { return WrappedObject.ImplementedInterfaces; }
        }

        public override TIndexerCollection Indexers
        {
            get { return WrappedObject.Indexers; }
        }

        public override IReadOnlyCollection<TNestedInterface> Interfaces
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
        
        public override IReadOnlyCollection<TOperatorOverload> OperatorOverloads
        {
            get { return WrappedObject.OperatorOverloads; }
        }
        
        public override TPropertyCollection Properties
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
        
        public IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> WrappedObject { get; private set; }

        public override StructMemberVisibilityModifier Visibility => WrappedObject.Visibility;
    }
}
