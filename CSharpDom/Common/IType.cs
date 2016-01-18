﻿namespace CSharpDom.Common
{
    public interface IType<TEvent,
        TProperty,
        TIndexer,
        TMethod,
        TField,
        TConstructor,
        TEventProperty,
        TOperatorOverload,
        TConversionOperator,
        TNestedClass,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStruct>
        : IBasicType<TEvent, TProperty, TIndexer, TMethod>,
        IHasFields<TField>,
        IHasConstructors<TConstructor>,
        IHasEventProperties<TEventProperty>,
        IHasOperatorOverloads<TOperatorOverload>,
        IHasConversionOperators<TConversionOperator>,
        IHasClasses<TNestedClass>,
        IHasDelegates<TNestedDelegate>,
        IHasEnums<TNestedEnum>,
        IHasInterfaces<TNestedInterface>,
        IHasStructs<TNestedStruct>
    {
    }
}
