using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableQueryLetExpression<TExpression> :
        AbstractExpression,
        IQueryLetExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public abstract string Identifier { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryLetExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryLetExpressionChildren(this, visitor);
        }
    }
}
