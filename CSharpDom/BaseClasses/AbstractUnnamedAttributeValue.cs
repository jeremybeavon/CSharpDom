using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractUnnamedAttributeValue<TExpression> :
        AbstractGenericVisitableObject,
        IUnnamedAttributeValue<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Value { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValue(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
