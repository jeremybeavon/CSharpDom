using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableQueryLetExpression<TBinaryOperatorExpression> :
        IQueryLetExpression<TBinaryOperatorExpression>
        where TBinaryOperatorExpression : IBinaryOperatorExpression
    {
        public abstract TBinaryOperatorExpression Expression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryLetExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryLetExpressionChildren(this, visitor);
        }
    }
}
