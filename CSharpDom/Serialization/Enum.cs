using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class Enum :
        IEnum<
            NamespaceNotSupported,
            DocumentNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroup,
            EnumMember>
    {
        public Enum()
        {
            Attributes = new List<AttributeGroup>();
            EnumMembers = new List<EnumMember>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public EnumBaseType BaseType { get; set; }

        public DocumentNotSupported Document
        {
            get { return null; }
        }

        public List<EnumMember> EnumMembers { get; set; }

        public string Name { get; set; }

        public NamespaceNotSupported Namespace
        {
            get { return null; }
        }

        public ProjectNotSupported Project
        {
            get { return null; }
        }

        public SolutionNotSupported Solution
        {
            get { return null; }
        }

        public TypeVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<EnumMember> IHasEnumMembers<EnumMember>.EnumMembers
        {
            get { return EnumMembers; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEnum(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEnumChildren(this, visitor);
        }
    }
}
