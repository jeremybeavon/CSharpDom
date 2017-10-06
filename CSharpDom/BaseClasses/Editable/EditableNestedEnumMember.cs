using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableNestedEnumMember<TAttributeGroup, TDeclaringType> :
        AbstractGenericVisitableObject,
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

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedEnumMember(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedEnumMemberChildren(this, visitor);
        }
    }
}
