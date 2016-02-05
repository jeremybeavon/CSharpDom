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
        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractAccessor(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
