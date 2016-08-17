using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public class EditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TNestedEnumMember : INestedEnumMember
    {
        public virtual ICollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual EnumBaseType BaseType { get; set; }

        public virtual IList<TNestedEnumMember> EnumMembers { get; set; }

        public virtual string Name { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyList<TNestedEnumMember> IHasEnumMembers<TNestedEnumMember>.EnumMembers
        {
            get { return new ReadOnlyCollection<TNestedEnumMember>(EnumMembers); }
        }

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
