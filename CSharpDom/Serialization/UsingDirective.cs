using System;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class UsingDirective : IUsingDirective
    {
        public string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUsingDirective(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
