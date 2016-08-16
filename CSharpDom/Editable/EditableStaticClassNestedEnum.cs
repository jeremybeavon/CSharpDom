using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        EditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>,
        IStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TNestedEnumMember : INestedEnumMember
    {
        public virtual ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassNestedEnum(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassNestedEnumChildren(this, visitor);
        }
    }
}
