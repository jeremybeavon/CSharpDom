﻿using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNestedEnumMember<TAttributeGroup, TDeclaringType> :
        AbstractGenericVisitableObject,
        INestedEnumMember<TAttributeGroup, TDeclaringType>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : INestedEnum
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract string Name { get; }

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
