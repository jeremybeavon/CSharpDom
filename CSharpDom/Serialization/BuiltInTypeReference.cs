using System;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class BuiltInTypeReference : IBuiltInTypeReference
    {
        public BuiltInType Type { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitBuiltInTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
