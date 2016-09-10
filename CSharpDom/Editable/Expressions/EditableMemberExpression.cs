using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableMemberExpression<TExpression> : IMemberExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract string MemberName { get; set; }

        public abstract TExpression ObjectExpression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitMemberExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitMemberExpressionChildren(this, visitor);
        }
    }
}
