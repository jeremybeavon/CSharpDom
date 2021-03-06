﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        AbstractGenericVisitableObject,
        INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TNestedEnumMember : INestedEnumMember
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract EnumBaseType BaseType { get; }

        public abstract IReadOnlyList<TNestedEnumMember> EnumMembers { get; }

        public abstract string Name { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedEnum(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedEnumChildren(this, visitor);
        }
    }
}
