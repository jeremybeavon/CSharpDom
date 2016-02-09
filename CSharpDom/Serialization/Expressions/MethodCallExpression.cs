using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class MethodCallExpression : IMethodCallExpression<Expression>
    {
        public MethodCallExpression()
        {
            ParameterExpressions = new List<Expression>();
        }
        
        public Expression Expression { get; set; }

        public List<Expression> ParameterExpressions { get; set; }

        IReadOnlyList<Expression> IMethodCallExpression<Expression>.ParameterExpressions
        {
            get { return ParameterExpressions; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitMethodCallExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitMethodCallExpressionChildren(this, visitor);
        }
    }
}
