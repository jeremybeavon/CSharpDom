﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassNestedSealedClass<
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
        AbstractNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>,
        IClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TGenericParameter : IGenericParameterDeclaration
        where TClassReference : IClassReference
        where TInterfaceReference : IInterfaceReference
        where TEventCollection : ISealedClassEventCollection
        where TPropertyCollection : ISealedClassPropertyCollection
        where TIndexerCollection : ISealedClassIndexerCollection
        where TMethodCollection : ISealedClassMethodCollection
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
        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedSealedClass(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassNestedSealedClassChildren(this, visitor);
        }
    }
}
