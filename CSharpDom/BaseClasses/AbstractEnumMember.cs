using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractEnumMember<TAttributeGroup, TDeclaringType> :
        AbstractGenericVisitableObject,
        IEnumMember<TAttributeGroup, TDeclaringType>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IEnum
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract string Name { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEnumMember(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEnumMemberChildren(this, visitor);
        }
    }
}
