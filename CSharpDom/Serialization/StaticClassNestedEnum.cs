using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassNestedEnum : IStaticClassNestedEnum<AttributeGroup, IStaticType, NestedEnumMember>
    {
        public StaticClassNestedEnum()
        {
            Attributes = new List<AttributeGroup>();
            EnumMembers = new List<NestedEnumMember>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public EnumBaseType BaseType { get; set; }

        public IStaticType DeclaringType
        {
            get { return null; }
        }

        public List<NestedEnumMember> EnumMembers { get; set; }

        public string Name { get; set; }
        
        public StaticClassMemberVisibilityModifier InheritanceModifier { get; set; }

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
            visitor.VisitStaticClassNestedEnum(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedEnumChildren(this, visitor);
        }
    }
}
