using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractField<TExpression> : AbstractGenericVisitableObject, IField<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression InitialValue { get; }

        public abstract string Name { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitField(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
