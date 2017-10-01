using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> :
        AbstractGenericVisitableObject,
        IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>
        where TNamespace : INamespace
        where TDocument : IDocument
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TEnumMember : IEnumMember
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract EnumBaseType BaseType { get; }

        public abstract TDocument Document { get; }

        public abstract IReadOnlyList<TEnumMember> EnumMembers { get; }

        public abstract string Name { get; }

        public abstract TNamespace Namespace { get; }

        public abstract TProject Project { get; }

        public abstract TSolution Solution { get; }

        public abstract TypeVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEnum(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEnumChildren(this, visitor);
        }
    }
}
