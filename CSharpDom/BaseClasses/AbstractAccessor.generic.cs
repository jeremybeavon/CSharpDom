using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAccessor<TAttributeGroup> : IAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
