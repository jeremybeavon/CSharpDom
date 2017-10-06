using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableQuerySelectIntoExpression<TExpression, TIdentifierExpression> :
        EditableQuerySelectExpression<TExpression>,
        IQuerySelectIntoExpression<TExpression, TIdentifierExpression>
        where TExpression : IExpression
        where TIdentifierExpression : IIdentifierExpression
    {
        public abstract TIdentifierExpression IntoExpression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQuerySelectIntoExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQuerySelectIntoExpressionChildren(this, visitor);
        }
    }
}
