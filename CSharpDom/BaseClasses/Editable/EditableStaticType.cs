using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStaticType<
        TAttributeGroup,
        TGenericParameter,
        TEventCollection,
        TProperty,
        TMethodCollection,
        TFieldCollection,
        TNestedClassCollection,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStructCollection,
        TStaticConstructor> :
        AbstractGenericVisitableObject,
        IStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TEventCollection : IStaticClassEventCollection
        where TProperty : IStaticClassProperty
        where TMethodCollection : IStaticClassMethodCollection
        where TFieldCollection : IStaticClassFieldCollection
        where TNestedClassCollection : IStaticClassNestedClassCollection
        where TNestedDelegate : IStaticClassNestedDelegate
        where TNestedEnum : IStaticClassNestedEnum
        where TNestedInterface : IStaticClassNestedInterface
        where TNestedStructCollection : IStaticClassNestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TNestedClassCollection Classes { get; set; }
        
        public abstract ICollection<TNestedDelegate> Delegates { get; set; }

        public abstract ICollection<TNestedEnum> Enums { get; set; }

        public abstract TEventCollection Events { get; set; }

        public abstract TFieldCollection Fields { get; set; }

        public abstract IList<TGenericParameter> GenericParameters { get; set; }

        public abstract ICollection<TNestedInterface> Interfaces { get; set; }

        public abstract TMethodCollection Methods { get; set; }

        public abstract string Name { get; set; }

        public abstract ICollection<TProperty> Properties { get; set; }

        public abstract TStaticConstructor StaticConstructor { get; set; }

        public abstract TNestedStructCollection Structs { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
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

        IReadOnlyCollection<TProperty> IHasProperties<TProperty>.Properties
        {
            get { return new ReadOnlyCollectionWrapper<TProperty>(Properties); }
        }

        IReadOnlyCollection<TNestedInterface> IHasInterfaces<TNestedInterface>.Interfaces =>
            new ReadOnlyCollectionWrapper<TNestedInterface>(Interfaces);

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticType(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticTypeChildren(this, visitor);
        }
    }
}
