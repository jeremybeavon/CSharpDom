using CSharpDom.Common;
using System.Collections.Generic;
using System;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class ClassTypeWrapper<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor> :
        AbstractClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>,
        IWrapper<IClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor, TDestructor>>
        where TAttributeGroup : IAttributeGroup
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
        where TNestedInterfaceCollection : IClassNestedInterfaceCollection
        where TNestedStructCollection : IClassNestedStructCollection
        where TStaticConstructor : IStaticConstructor
        where TDestructor : IDestructor
    {
        public ClassTypeWrapper(IClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor, TDestructor> type)
        {
            WrappedObject = type;
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

        public IClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor, TDestructor> WrappedObject { get; private set; }
    }
}
