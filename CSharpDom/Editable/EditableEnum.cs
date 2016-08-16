using System;
using System.Collections.Generic;
using CSharpDom.Common;

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
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual EnumBaseType BaseType { get; set; }

        public virtual TDocument Document { get; set; }

        public virtual IReadOnlyList<TEnumMember> EnumMembers { get; set; }

        public virtual string Name { get; set; }

        public virtual TNamespace Namespace { get; set; }

        public virtual TProject Project { get; set; }

        public virtual TSolution Solution { get; set; }

        public virtual TypeVisibilityModifier Visibility { get; set; }

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
