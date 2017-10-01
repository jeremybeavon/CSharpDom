using CSharpDom.Common;
using System;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractUsingDirective : AbstractGenericVisitableObject, IUsingDirective
    {
        public abstract string Name { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUsingDirective(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
