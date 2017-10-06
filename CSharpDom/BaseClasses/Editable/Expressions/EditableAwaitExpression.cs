using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableAwaitExpression<TExpression> : AbstractExpression, IAwaitExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitAwaitExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitAwaitExpressionChildren(this, visitor);
        }
    }
}
