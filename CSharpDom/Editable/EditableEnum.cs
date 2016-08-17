using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public class EditableEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> :
        IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>
        where TNamespace : INamespace
        where TDocument : IDocument
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TEnumMember : IEnumMember
    {
        public virtual ICollection<TAttributeGroup> Attributes { get; set; }

        public virtual EnumBaseType BaseType { get; set; }

        public virtual TDocument Document { get; set; }

        public virtual IList<TEnumMember> EnumMembers { get; set; }

        public virtual string Name { get; set; }

        public virtual TNamespace Namespace { get; set; }

        public virtual TProject Project { get; set; }

        public virtual TSolution Solution { get; set; }

        public virtual TypeVisibilityModifier Visibility { get; set; }

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
