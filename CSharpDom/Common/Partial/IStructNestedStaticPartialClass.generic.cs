﻿namespace CSharpDom.Common.Partial
{
    public interface IStructNestedStaticPartialClass<TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TEventCollection,
        TPropertyCollection,
        TMethodCollection,
        TFieldCollection,
        TNestedClassCollection,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStructCollection,
        TStaticConstructor> :
        IStructNestedStaticPartialClass,
        IStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TGenericParameter : IGenericParameterDeclaration
        where TEventCollection : IStaticClassEventCollection
        where TPropertyCollection : IStaticClassPropertyCollection
        where TMethodCollection : INestedStaticPartialClassMethodCollection
        where TFieldCollection : IStaticClassFieldCollection
        where TNestedClassCollection : IStaticClassNestedClassCollection
        where TNestedDelegate : IStaticClassNestedDelegate
        where TNestedEnum : IStaticClassNestedEnum
        where TNestedInterface : IStaticClassNestedInterface
        where TNestedStructCollection : IStaticClassNestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
    }
}
