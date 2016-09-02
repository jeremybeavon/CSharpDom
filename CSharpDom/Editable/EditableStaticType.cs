using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public class EditableStaticType<
        TAttributeGroup,
        TGenericParameter,
        TEventCollection,
        TProperty,
        TMethodCollection,
        TFieldCollection,
        TNestedClassCollection,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterfaceCollection,
        TNestedStructCollection,
        TStaticConstructor> :
        IStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TEventCollection : IStaticClassEventCollection
        where TProperty : IStaticClassProperty
        where TMethodCollection : IStaticClassMethodCollection
        where TFieldCollection : IStaticClassFieldCollection
        where TNestedClassCollection : IStaticClassNestedClassCollection
        where TNestedDelegate : IStaticClassNestedDelegate
        where TNestedEnum : IStaticClassNestedEnum
        where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
        where TNestedStructCollection : IStaticClassNestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
        public virtual ICollection<TAttributeGroup> Attributes { get; set; }

        public virtual TNestedClassCollection Classes { get; set; }
        
        public virtual ICollection<TNestedDelegate> Delegates { get; set; }

        public virtual ICollection<TNestedEnum> Enums { get; set; }

        public virtual TEventCollection Events { get; set; }

        public virtual TFieldCollection Fields { get; set; }

        public virtual IList<TGenericParameter> GenericParameters { get; set; }

        public virtual TNestedInterfaceCollection Interfaces { get; set; }

        public virtual TMethodCollection Methods { get; set; }

        public virtual string Name { get; set; }

        public virtual ICollection<TProperty> Properties { get; set; }

        public virtual TStaticConstructor StaticConstructor { get; set; }

        public virtual TNestedStructCollection Structs { get; set; }

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

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticType(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticTypeChildren(this, visitor);
        }
    }
}
