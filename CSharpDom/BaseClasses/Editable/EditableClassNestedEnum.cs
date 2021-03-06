﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        EditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>,
        IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TNestedEnumMember : INestedEnumMember
    {
        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedEnum(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassNestedEnumChildren(this, visitor);
        }
    }
}
