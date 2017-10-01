using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableQueryWhereExpression<TExpression> :
        AbstractExpression,
        IQueryWhereExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryWhereExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryWhereExpressionChildren(this, visitor);
        }
    }
}
