using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractBuiltInTypeReference : AbstractGenericVisitableObject, IBuiltInTypeReference
    {
        public abstract BuiltInType Type { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitBuiltInTypeReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
