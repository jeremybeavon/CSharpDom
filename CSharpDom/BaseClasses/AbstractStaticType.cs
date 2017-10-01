using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticType<
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
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TNestedClassCollection Classes { get; }
        
        public abstract IReadOnlyCollection<TNestedDelegate> Delegates { get; }

        public abstract IReadOnlyCollection<TNestedEnum> Enums { get; }

        public abstract TEventCollection Events { get; }

        public abstract TFieldCollection Fields { get; }

        public abstract IReadOnlyList<TGenericParameter> GenericParameters { get; }

        public abstract IReadOnlyCollection<TNestedInterface> Interfaces { get; }

        public abstract TMethodCollection Methods { get; }

        public abstract string Name { get; }

        public abstract IReadOnlyCollection<TProperty> Properties { get; }

        public abstract TStaticConstructor StaticConstructor { get; }

        public abstract TNestedStructCollection Structs { get; }

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
