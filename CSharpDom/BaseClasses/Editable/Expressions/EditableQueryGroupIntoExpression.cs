using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableQueryGroupIntoExpression<TExpression, TIdentifierExpression> :
        EditableQueryGroupExpression<TExpression>,
        IQueryGroupIntoExpression<TExpression, TIdentifierExpression>
        where TExpression : IExpression
        where TIdentifierExpression : IIdentifierExpression
    {
        public abstract TIdentifierExpression IntoExpression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryGroupIntoExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryGroupIntoExpressionChildren(this, visitor);
        }
    }
}
