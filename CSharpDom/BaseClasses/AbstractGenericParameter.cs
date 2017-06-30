using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractGenericParameter<TTypeReference> : IGenericParameter
        where TTypeReference : ITypeReference
    {
        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameter(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitGenericParameter(this, visitor);
        }
    }
}
