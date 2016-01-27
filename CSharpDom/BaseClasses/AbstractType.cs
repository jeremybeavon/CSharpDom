using System.Collections.Generic;
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
        TNestedStruct> :
        AbstractBasicType<TEvent, TProperty, TIndexer, TMethod>,
        IType<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>
    {
        public abstract IReadOnlyCollection<TNestedClass> Classes { get; }

        public abstract IReadOnlyCollection<TConstructor> Constructors { get; }

        public abstract IReadOnlyCollection<TConversionOperator> ConversionOperators { get; }

        public abstract IReadOnlyCollection<TNestedDelegate> Delegates { get; }

        public abstract IReadOnlyCollection<TNestedEnum> Enums { get; }

        public abstract IReadOnlyCollection<TEventProperty> EventProperties { get; }

        public abstract IReadOnlyCollection<TField> Fields { get; }

        public abstract IReadOnlyCollection<TNestedInterface> Interfaces { get; }

        public abstract IReadOnlyCollection<TOperatorOverload> OperatorOverloads { get; }

        public abstract IReadOnlyCollection<TNestedStruct> Structs { get; }
    }
}
