using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNullableTypeReference<TStructReference> :
        AbstractGenericVisitableObject,
        INullableTypeReference<TStructReference>
        where TStructReference : IStructReference
    {
        public abstract TStructReference Type { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNullableTypeReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNullableTypeReference(this, visitor);
        }
    }
}
