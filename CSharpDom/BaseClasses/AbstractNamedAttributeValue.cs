using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNamedAttributeValue<TExpression> :
        AbstractGenericVisitableObject,
        INamedAttributeValue<TExpression>
        where TExpression : IExpression
    {
        public abstract string Name { get; }

        public abstract TExpression Value { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNamedAttributeValue(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
