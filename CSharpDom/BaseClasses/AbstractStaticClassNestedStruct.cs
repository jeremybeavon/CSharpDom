﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassNestedStruct<TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TInterfaceReference,
        TEvent,
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
        TNestedStruct,
        TStaticConstructor,
        TExplicitInterfaceEvent,
        TExplicitInterfaceProperty,
        TExplicitInterfaceIndexer,
        TExplicitInterfaceMethod> :
        AbstractNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>,
        IStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEvent : IStructEvent
        where TProperty : IStructProperty
        where TIndexer : IStructIndexer
        where TMethod : IStructMethod
        where TField : IStructField
        where TConstructor : IStructConstructor
        where TEventProperty : IStructEventProperty
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClass : IStructNestedClass
        where TNestedDelegate : IStructNestedDelegate
        where TNestedEnum : IStructNestedEnum
        where TNestedInterface : IStructNestedInterface
        where TNestedStruct : IStructNestedStruct
        where TStaticConstructor : IStaticConstructor
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public abstract StaticClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassNestedStruct(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            base.Accept(visitor);
        }
    }
}