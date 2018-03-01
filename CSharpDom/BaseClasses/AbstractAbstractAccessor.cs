using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAbstractAccessor<TAttributeGroup> : 
        AbstractAccessor<TAttributeGroup>,
        IAbstractAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
        public abstract AbstractAccessorVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractAccessor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractAccessorChildren(this, visitor);
        }
    }
}
