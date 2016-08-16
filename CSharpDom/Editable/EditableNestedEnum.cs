using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TNestedEnumMember : INestedEnumMember
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual EnumBaseType BaseType { get; set; }

        public virtual IReadOnlyList<TNestedEnumMember> EnumMembers { get; set; }

        public virtual string Name { get; set; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedEnum(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedEnumChildren(this, visitor);
        }
    }
}
