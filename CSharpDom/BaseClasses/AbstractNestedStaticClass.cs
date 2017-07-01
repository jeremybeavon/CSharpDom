using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNestedStaticClass<
        TAttributeGroup,
        TDeclaringType,
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
        AbstractStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>,
        INestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TEventCollection : IStaticClassEventCollection
        where TProperty : IStaticClassProperty
        where TMethodCollection : INestedStaticClassMethodCollection
        where TFieldCollection : IStaticClassFieldCollection
        where TNestedClassCollection : IStaticClassNestedClassCollection
        where TNestedDelegate : IStaticClassNestedDelegate
        where TNestedEnum : IStaticClassNestedEnum
        where TNestedInterface : IStaticClassNestedInterface
        where TNestedStructCollection : IStaticClassNestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
        public abstract TDeclaringType DeclaringType { get; }
        
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedStaticClass(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedStaticClassChildren(this, visitor);
        }
    }
}
