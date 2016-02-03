using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAccessor<TAttributeGroup, TMethodBody> :
        AbstractAccessor<TAttributeGroup>,
        IAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
        public abstract TMethodBody Body { get; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAccessor(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAccessor(this, visitor);
        }
    }
}
