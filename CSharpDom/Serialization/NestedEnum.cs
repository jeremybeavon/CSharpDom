using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class NestedEnum : INestedEnum<AttributeGroup, IType, NestedEnumMember>
    {
        public NestedEnum()
        {
            Attributes = new List<AttributeGroup>();
            EnumMembers = new List<NestedEnumMember>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public List<NestedEnumMember> EnumMembers { get; set; }

        public string Name { get; set; }
        
        public MemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<NestedEnumMember> IHasEnumMembers<NestedEnumMember>.EnumMembers
        {
            get { return EnumMembers; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedEnum(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedEnumChildren(this, visitor);
        }
    }
}
