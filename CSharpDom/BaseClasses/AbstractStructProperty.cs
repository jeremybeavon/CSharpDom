﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        AbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TTypeReference : ITypeReference
        where TAccessor : IStructAccessor
    {
        public abstract StructMemberInheritanceModifier InheritanceModifier { get; }

        public abstract StructMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructPropertyChildren(this, visitor);
        }
    }
}
