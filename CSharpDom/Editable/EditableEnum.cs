using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public abstract class EditableEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> :
        IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>
        where TNamespace : INamespace
        where TDocument : IDocument
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TEnumMember : IEnumMember
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract EnumBaseType BaseType { get; set; }

        public abstract TDocument Document { get; set; }

        public abstract IList<TEnumMember> EnumMembers { get; set; }

        public abstract string Name { get; set; }

        public abstract TNamespace Namespace { get; set; }

        public abstract TProject Project { get; set; }

        public abstract TSolution Solution { get; set; }

        public abstract TypeVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyList<TEnumMember> IHasEnumMembers<TEnumMember>.EnumMembers
        {
            get { return new ReadOnlyCollection<TEnumMember>(EnumMembers); }
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
