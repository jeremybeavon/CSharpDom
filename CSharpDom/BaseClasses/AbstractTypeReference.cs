using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractTypeReference : ITypeReference
    {
        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitTypeReference(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
