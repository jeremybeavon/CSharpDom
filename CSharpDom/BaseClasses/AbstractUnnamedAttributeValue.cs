using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractUnnamedAttributeValue<TExpression> : IUnnamedAttributeValue<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Value { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValue(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
