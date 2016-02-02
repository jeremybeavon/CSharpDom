﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        AbstractNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>,
        IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TNestedEnumMember : INestedEnumMember
    {
        public abstract StructMemberVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructNestedEnum(this);
        }
    }
}
