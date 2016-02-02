﻿using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractType<TEvent,
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
        AbstractBasicType<TEvent, TProperty, TIndexer, TMethod>,
        IType<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>
    {
        public abstract IReadOnlyCollection<TNestedClass> Classes { get; }

        public abstract IReadOnlyCollection<TConstructor> Constructors { get; }

        public abstract IReadOnlyCollection<TConversionOperator> ConversionOperators { get; }

        public abstract IReadOnlyCollection<TNestedDelegate> Delegates { get; }

        public abstract IReadOnlyCollection<TNestedEnum> Enums { get; }

        public abstract IReadOnlyCollection<TEventProperty> EventProperties { get; }

        public abstract IReadOnlyCollection<TExplicitInterfaceEvent> ExplicitInterfaceEvents { get; }

        public abstract IReadOnlyCollection<TExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; }

        public abstract IReadOnlyCollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods { get; }

        public abstract IReadOnlyCollection<TExplicitInterfaceProperty> ExplicitInterfaceProperties { get; }

        public abstract IReadOnlyCollection<TField> Fields { get; }

        public abstract IReadOnlyCollection<TNestedInterface> Interfaces { get; }

        public abstract IReadOnlyCollection<TOperatorOverload> OperatorOverloads { get; }

        public abstract TStaticConstructor StaticConstructor { get; }

        public abstract IReadOnlyCollection<TNestedStruct> Structs { get; }
    }
}
