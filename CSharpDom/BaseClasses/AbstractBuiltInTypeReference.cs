using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractBuiltInTypeReference : IBuiltInTypeReference
    {
        public abstract BuiltInType Type { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitBuiltInTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
