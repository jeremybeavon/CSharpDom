using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableMemberExpression<TExpression> : AbstractExpression, IMemberExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract string MemberName { get; set; }

        public abstract TExpression ObjectExpression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitMemberExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitMemberExpressionChildren(this, visitor);
        }
    }
}
