﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Editable.Partial
{
    public abstract class EditableStaticClassNestedSealedPartialClass<
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
        TNestedDestructor,
        TStaticConstructor> :
        EditableStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TNestedDestructor, TStaticConstructor>,
        IStaticClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TNestedDestructor, TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TGenericParameter : IGenericParameterDeclaration
        where TClassReference : IClassReference
        where TInterfaceReference : IInterfaceReference
        where TEventCollection : ISealedClassEventCollection
        where TPropertyCollection : ISealedClassPropertyCollection
        where TIndexerCollection : ISealedClassIndexerCollection
        where TMethodCollection : ISealedPartialClassMethodCollection
        where TFieldCollection : IClassFieldCollection
        where TConstructor : IClassConstructor
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClassCollection : IClassNestedClassCollection
        where TNestedDelegate : IClassNestedDelegate
        where TNestedEnum : IClassNestedEnum
        where TNestedInterface : IClassNestedInterface
        where TNestedStructCollection : IClassNestedStructCollection
        where TNestedDestructor : INestedDestructor
        where TStaticConstructor : IStaticConstructor
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassNestedSealedPartialClass(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassNestedSealedPartialClassChildren(this, visitor);
        }
    }
}
