using CSharpDom.Common;
using System.Collections.Generic;
using System;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableNestedEnumMember<TAttributeGroup, TDeclaringType> :
        INestedEnumMember<TAttributeGroup, TDeclaringType>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : INestedEnum
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        public abstract string Name { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
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
