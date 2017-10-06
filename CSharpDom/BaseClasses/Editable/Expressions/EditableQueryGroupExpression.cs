using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableQueryGroupExpression<TExpression> :
        AbstractExpression,
        IQueryGroupExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression ByExpression { get; set; }

        public abstract TExpression GroupExpression { get; set; }
        
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryGroupExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryGroupExpressionChildren(this, visitor);
        }
    }
}