using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public abstract class EditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        AbstractGenericVisitableObject,
        INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TNestedEnumMember : INestedEnumMember
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        public abstract EnumBaseType BaseType { get; set; }

        public abstract IList<TNestedEnumMember> EnumMembers { get; set; }

        public abstract string Name { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyList<TNestedEnumMember> IHasEnumMembers<TNestedEnumMember>.EnumMembers
        {
            get { return new ReadOnlyCollection<TNestedEnumMember>(EnumMembers); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedEnum(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedEnumChildren(this, visitor);
        }
    }
}
