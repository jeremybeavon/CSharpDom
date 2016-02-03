using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNullableTypeReference<TStructReference> :
        INullableTypeReference<TStructReference>
        where TStructReference : IStructReference
    {
        public abstract TStructReference Type { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNullableTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNullableTypeReference(this, visitor);
        }
    }
}
