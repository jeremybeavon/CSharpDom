using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableEnumMember<TAttributeGroup, TDeclaringType> : IEnumMember<TAttributeGroup, TDeclaringType>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IEnum
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
            visitor.VisitEnumMember(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEnumMemberChildren(this, visitor);
        }
    }
}
