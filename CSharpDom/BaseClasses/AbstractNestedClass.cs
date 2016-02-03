using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNestedClass<TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TClassReference,
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
        TNestedDestructor,
        TStaticConstructor,
        TExplicitInterfaceEvent,
        TExplicitInterfaceProperty,
        TExplicitInterfaceIndexer,
        TExplicitInterfaceMethod> :
        AbstractType<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>,
        INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TClassReference : IClassReference
        where TInterfaceReference : IInterfaceReference
        where TEvent : IClassEvent
        where TProperty : IClassProperty
        where TIndexer : IClassIndexer
        where TMethod : IClassMethod
        where TField : IClassField
        where TConstructor : IClassConstructor
        where TEventProperty : IClassEventProperty
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClass : IClassNestedClass
        where TNestedDelegate : IClassNestedDelegate
        where TNestedEnum : IClassNestedEnum
        where TNestedInterface : IClassNestedInterface
        where TNestedStruct : IClassNestedStruct
        where TNestedDestructor : INestedDestructor
        where TStaticConstructor : IStaticConstructor
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TClassReference BaseClass { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract TNestedDestructor Destructor { get; }

        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }

        public abstract IReadOnlyCollection<TInterfaceReference> ImplementedInterfaces { get; }

        public abstract TypeInheritanceModifier InheritanceModifier { get; }

        public abstract bool IsPartial { get; }

        public abstract string Name { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedClass(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedClassChildren(this, visitor);
            base.Accept(visitor);
        }
    }
}
