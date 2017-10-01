using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using CSharpDom.BaseClasses.Expressions;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableMethodCallExpression<TExpression> :
        AbstractExpression,
        IMethodCallExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public abstract IList<TExpression> ParameterExpressions { get; set; }

        IReadOnlyList<TExpression> IMethodCallExpression<TExpression>.ParameterExpressions
        {
            get { return new ReadOnlyCollection<TExpression>(ParameterExpressions); }
        }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitMethodCallExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitMethodCallExpressionChildren(this, visitor);
        }
    }
}
