﻿namespace CSharpDom.Common.Partial
{
    public interface IStructNestedAbstractPartialClass<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TClassReference,
        TInterfaceReference,
        TEventCollection,
        TPropertyCollection,
        TIndexerCollection,
        TMethodCollection,
        TFieldCollection,
        TConstructor,
        TOperatorOverload,
        TConversionOperator,
        TNestedClassCollection,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStructCollection,
        TStaticConstructor,
        TDestructor> :
        IStructNestedAbstractPartialClass,
        IStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TGenericParameter : IGenericParameterDeclaration
        where TClassReference : IClassReference
        where TInterfaceReference : IInterfaceReference
        where TEventCollection : IAbstractClassEventCollection
        where TPropertyCollection : IAbstractClassPropertyCollection
        where TIndexerCollection : IAbstractClassIndexerCollection
        where TMethodCollection : IAbstractPartialClassMethodCollection
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
    }
}
