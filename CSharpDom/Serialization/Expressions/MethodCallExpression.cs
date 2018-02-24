using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class MethodCallExpression : IMethodCallExpression<Expression, Argument>
    {
        public MethodCallExpression()
        {
            Parameters = new List<Argument>();
        }
        
        public Expression Expression { get; set; }

        public List<Argument> Parameters { get; set; }

        IReadOnlyList<Argument> IMethodCallExpression<Expression, Argument>.Parameters
        {
            get { return Parameters; }
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
