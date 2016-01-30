using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class EnumMember : IEnumMember<AttributeGroup, EnumNotSupported>
    {
        public IReadOnlyCollection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public EnumNotSupported DeclaringType
        {
            get { return null; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEnumMember(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEnumMemberChildren(this, visitor);
        }
    }
}
