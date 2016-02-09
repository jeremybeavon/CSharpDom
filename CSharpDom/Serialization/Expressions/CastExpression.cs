using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class CastExpression : ICastExpression<TypeReference, Expression>
    {
        public Expression Expression { get; set; }

        public TypeReference Type { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitCastExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitCastExpressionChildren(this, visitor);
        }
    }
}
