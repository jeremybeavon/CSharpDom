using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class QueryJoinExpression : IQueryJoinExpression<Expression>
    {
        public Expression EqualsExpression { get; set; }

        public Expression InExpression { get; set; }

        public string IntoVariable { get; set; }

        public string JoinVariable { get; set; }

        public Expression OnExpression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryJoinExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryJoinExpressionChildren(this, visitor);
        }
    }
}
