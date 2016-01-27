using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAttributeGroup<TAttribute> : IAttributeGroup<TAttribute>
        where TAttribute : IAttribute
    {
        public abstract IReadOnlyCollection<TAttribute> Attributes { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAttributeGroup(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAttributeGroupChildren(this, visitor);
        }
    }
}
