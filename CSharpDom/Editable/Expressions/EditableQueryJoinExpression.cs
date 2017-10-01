﻿using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableQueryJoinExpression<TExpression> :
        AbstractExpression,
        IQueryJoinExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression EqualsExpression { get; set; }

        public abstract TExpression InExpression { get; set; }

        public abstract string IntoVariable { get; set; }

        public abstract string JoinVariable { get; set; }

        public abstract TExpression OnExpression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryJoinExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryJoinExpressionChildren(this, visitor);
        }
    }
}
