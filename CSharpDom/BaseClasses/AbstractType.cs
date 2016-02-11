using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractType<
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
        TNestedInterfaceCollection,
        TNestedStructCollection,
        TStaticConstructor> :
        IType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>
        where TEventCollection : IEventCollection
        where TPropertyCollection : IPropertyCollection
        where TIndexerCollection : IIndexerCollection
        where TMethodCollection : IMethodCollection
        where TFieldCollection : IFieldCollection
        where TConstructor : IConstructor
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClassCollection : INestedClassCollection
        where TNestedDelegate : INestedDelegate
        where TNestedEnum : INestedEnum
        where TNestedInterfaceCollection : INestedInterfaceCollection
        where TNestedStructCollection : INestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
        public abstract TNestedClassCollection Classes { get; }

        public abstract IReadOnlyCollection<TConstructor> Constructors { get; }

        public abstract IReadOnlyCollection<TConversionOperator> ConversionOperators { get; }

        public abstract IReadOnlyCollection<TNestedDelegate> Delegates { get; }

        public abstract IReadOnlyCollection<TNestedEnum> Enums { get; }

        public abstract TEventCollection Events { get; }

        public abstract TFieldCollection Fields { get; }

        public abstract TIndexerCollection Indexers { get; }

        public abstract TNestedInterfaceCollection Interfaces { get; }

        public abstract TMethodCollection Methods { get; }

        public abstract IReadOnlyCollection<TOperatorOverload> OperatorOverloads { get; }

        public abstract TPropertyCollection Properties { get; }

        public abstract TStaticConstructor StaticConstructor { get; }

        public abstract TNestedStructCollection Structs { get; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitType(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitTypeChildren(this, visitor);
        }
    }
}
