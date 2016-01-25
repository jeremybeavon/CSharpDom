using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractGenericParameter<TTypeReference> : IGenericParameter<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract TTypeReference Type { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameter(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitGenericParameter(this, visitor);
        }
    }
}
