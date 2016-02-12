using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractConstant<TExpression> : IConstant<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression ConstantValue { get; }

        public abstract string Name { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConstant(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
