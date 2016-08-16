using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableType<
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
        public virtual TNestedClassCollection Classes { get; set; }

        public virtual IReadOnlyCollection<TConstructor> Constructors { get; set; }

        public virtual IReadOnlyCollection<TConversionOperator> ConversionOperators { get; set; }

        public virtual IReadOnlyCollection<TNestedDelegate> Delegates { get; set; }

        public virtual IReadOnlyCollection<TNestedEnum> Enums { get; set; }

        public virtual TEventCollection Events { get; set; }

        public virtual TFieldCollection Fields { get; set; }

        public virtual TIndexerCollection Indexers { get; set; }

        public virtual TNestedInterfaceCollection Interfaces { get; set; }

        public virtual TMethodCollection Methods { get; set; }

        public virtual IReadOnlyCollection<TOperatorOverload> OperatorOverloads { get; set; }

        public virtual TPropertyCollection Properties { get; set; }

        public virtual TStaticConstructor StaticConstructor { get; set; }

        public virtual TNestedStructCollection Structs { get; set; }

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
