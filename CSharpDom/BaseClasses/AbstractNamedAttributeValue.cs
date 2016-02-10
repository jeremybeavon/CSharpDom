using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNamedAttributeValue<TExpression> : INamedAttributeValue<TExpression>
        where TExpression : IExpression
    {
        public abstract string Name { get; }

        public abstract TExpression Value { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNamedAttributeValue(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
