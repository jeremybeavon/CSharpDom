using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableQueryJoinExpression<TExpression> :
        IQueryJoinExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression EqualsExpression { get; set; }

        public abstract TExpression InExpression { get; set; }

        public abstract string IntoVariable { get; set; }

        public abstract string JoinVariable { get; set; }

        public abstract TExpression OnExpression { get; set; }

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
