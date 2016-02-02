using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAccessor<TAttributeGroup, TMethodBody> : IAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TMethodBody Body { get; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            throw new NotSupportedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAccessor(this, visitor);
        }
    }
}
