using CSharpDom.Common;
using System;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractUsingDirective : IUsingDirective
    {
        public abstract string Name { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUsingDirective(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
