using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableQueryOrderingExpression<TExpression> :
        AbstractExpression,
        IQueryOrderingExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public abstract QueryOrderByType OrderByType { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryOrderingExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryOrderingExpressionChildren(this, visitor);
        }
    }
}
