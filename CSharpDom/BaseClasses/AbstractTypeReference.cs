using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractTypeReference : AbstractGenericVisitableObject, ITypeReference
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitTypeReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
