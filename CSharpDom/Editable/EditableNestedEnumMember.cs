using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Editable
{
    public class EditableNestedEnumMember<TAttributeGroup, TDeclaringType> :
        INestedEnumMember<TAttributeGroup, TDeclaringType>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : INestedEnum
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual string Name { get; set; }

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
