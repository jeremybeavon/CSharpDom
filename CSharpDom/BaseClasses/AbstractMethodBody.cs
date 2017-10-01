using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractMethodBody<TStatement> : AbstractGenericVisitableObject, IMethodBody<TStatement>
    {
        public abstract IReadOnlyList<TStatement> Statements { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitMethodBody(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
