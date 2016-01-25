﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember> :
        IEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember>
        where TNamespace : INamespace
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TEnumMember : IEnumMember
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract IReadOnlyCollection<TEnumMember> EnumMembers { get; }

        public abstract string Name { get; }

        public abstract TNamespace Namespace { get; }

        public abstract TProject Project { get; }

        public abstract TSolution Solution { get; }

        public abstract TypeVisibilityModifier Visibility { get; }

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
