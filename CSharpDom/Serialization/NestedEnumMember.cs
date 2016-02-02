using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class NestedEnumMember : INestedEnumMember<AttributeGroup, IClassNestedEnum>
    {
        public NestedEnumMember()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IClassNestedEnum DeclaringType
        {
            get { return null; }
        }

        public string Name { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedEnumMember(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedEnumMemberChildren(this, visitor);
        }
    }
}
