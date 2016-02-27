using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        AbstractNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>,
        IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TNestedEnumMember : INestedEnumMember
    {
        public abstract ClassMemberVisibilityModifier Visibility { get; }

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
