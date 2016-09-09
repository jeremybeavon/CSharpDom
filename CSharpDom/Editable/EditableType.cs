using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public abstract class EditableType<
        TAttributeGroup,
        TGenericParameter,
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
        TNestedInterfaceCollection,
        TNestedStructCollection,
        TStaticConstructor> :
        IType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
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
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TNestedClassCollection Classes { get; set; }

        public abstract ICollection<TConstructor> Constructors { get; set; }

        public abstract ICollection<TConversionOperator> ConversionOperators { get; set; }

        public abstract ICollection<TNestedDelegate> Delegates { get; set; }

        public abstract ICollection<TNestedEnum> Enums { get; set; }

        public abstract TEventCollection Events { get; set; }

        public abstract TFieldCollection Fields { get; set; }

        public abstract IList<TGenericParameter> GenericParameters { get; set; }

        public abstract ICollection<TInterfaceReference> ImplementedInterfaces { get; set; }

        public abstract TIndexerCollection Indexers { get; set; }

        public abstract TNestedInterfaceCollection Interfaces { get; set; }

        public abstract TMethodCollection Methods { get; set; }

        public abstract string Name { get; set; }

        public abstract ICollection<TOperatorOverload> OperatorOverloads { get; set; }

        public abstract TPropertyCollection Properties { get; set; }

        public abstract TStaticConstructor StaticConstructor { get; set; }

        public abstract TNestedStructCollection Structs { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyCollection<TConstructor> IHasConstructors<TConstructor>.Constructors
        {
            get { return new ReadOnlyCollectionWrapper<TConstructor>(Constructors); }
        }

        IReadOnlyCollection<TConversionOperator> IHasConversionOperators<TConversionOperator>.ConversionOperators
        {
            get { return new ReadOnlyCollectionWrapper<TConversionOperator>(ConversionOperators); }
        }

        IReadOnlyCollection<TNestedDelegate> IHasDelegates<TNestedDelegate>.Delegates
        {
            get { return new ReadOnlyCollectionWrapper<TNestedDelegate>(Delegates); }
        }

        IReadOnlyCollection<TNestedEnum> IHasEnums<TNestedEnum>.Enums
        {
            get { return new ReadOnlyCollectionWrapper<TNestedEnum>(Enums); }
        }

        IReadOnlyList<TGenericParameter> IHasGenericParameters<TGenericParameter>.GenericParameters
        {
            get { return new ReadOnlyCollection<TGenericParameter>(GenericParameters); }
        }

        IReadOnlyCollection<TInterfaceReference> IHasImplementedInterfaces<TInterfaceReference>.ImplementedInterfaces
        {
            get { return new ReadOnlyCollectionWrapper<TInterfaceReference>(ImplementedInterfaces); }
        }

        IReadOnlyCollection<TOperatorOverload> IHasOperatorOverloads<TOperatorOverload>.OperatorOverloads
        {
            get { return new ReadOnlyCollectionWrapper<TOperatorOverload>(OperatorOverloads); }
        }

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
