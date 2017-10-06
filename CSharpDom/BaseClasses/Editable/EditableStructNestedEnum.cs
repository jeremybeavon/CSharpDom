using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        EditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>,
        IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TNestedEnumMember : INestedEnumMember
    {
        public abstract StructMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructNestedEnum(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructNestedEnumChildren(this, visitor);
        }
    }
}
