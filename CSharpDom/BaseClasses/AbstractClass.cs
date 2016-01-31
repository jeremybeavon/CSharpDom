using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClass<TNamespace,
        TProject,
        TSolution,
        TAttributeGroup,
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
        TDestructor> :
        AbstractType<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>,
        IClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor>
        where TNamespace : INamespace
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TClassReference : IClassReference
        where TInterfaceReference : IInterfaceReference
        where TEvent : IEvent
        where TProperty : IProperty
        where TIndexer : IIndexer
        where TMethod : IMethod
        where TField : IField
        where TConstructor : IConstructor
        where TEventProperty : IEventProperty
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClass : INestedClass
        where TNestedDelegate : INestedDelegate
        where TNestedEnum : INestedEnum
        where TNestedInterface : INestedInterface
        where TNestedStruct : INestedStruct
        where TDestructor : IDestructor
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TClassReference BaseClass { get; }

        public abstract TDestructor Destructor { get; }

        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }

        public abstract IReadOnlyCollection<TInterfaceReference> ImplementedInterfaces { get; }

        public abstract TypeInheritanceModifier InheritanceModifier { get; }

        public abstract bool IsPartial { get; }

        public abstract string Name { get; }

        public abstract TNamespace Namespace { get; }

        public abstract TProject Project { get; }

        public abstract TSolution Solution { get; }

        public abstract TypeVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClass(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassChildren(this, visitor);
        }
    }
}
