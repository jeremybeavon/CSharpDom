using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableQueryFromExpression<TExpression> :
        AbstractExpression,
        IQueryFromExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public abstract string Identifier { get; set; }
        
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryFromExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryFromExpressionChildren(this, visitor);
        }
    }
}
