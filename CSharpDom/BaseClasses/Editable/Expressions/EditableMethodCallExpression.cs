using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableMethodCallExpression<TExpression> :
        EditableExpression,
        IEditableMethodCallExpression<TExpression>
        where TExpression : IEditableExpression
    {
        public abstract TExpression Expression { get; set; }

        public abstract IList<TExpression> ParameterExpressions { get; set; }

        IReadOnlyList<TExpression> IMethodCallExpression<TExpression>.ParameterExpressions
        {
            get { return new ReadOnlyCollection<TExpression>(ParameterExpressions); }
        }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitMethodCallExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitMethodCallExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitMethodCallExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
