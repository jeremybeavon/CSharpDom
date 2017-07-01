using CSharpDom.Common;
using System.Collections.Generic;
using System;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class StructTypeWrapper<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> :
        AbstractStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>,
        IWrapper<IStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEventCollection : IStructEventCollection
        where TPropertyCollection : IStructPropertyCollection
        where TIndexerCollection : IStructIndexerCollection
        where TMethodCollection : IStructMethodCollection
        where TFieldCollection : IStructFieldCollection
        where TConstructor : IStructConstructor
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClassCollection : IStructNestedClassCollection
        where TNestedDelegate : IStructNestedDelegate
        where TNestedEnum : IStructNestedEnum
        where TNestedInterface : IStructNestedInterface
        where TNestedStructCollection : IStructNestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
        public StructTypeWrapper(IStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
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

        public IStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> WrappedObject { get; private set; }
    }
}
