using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableMethodCallExpression<TExpression, TArgument> :
        EditableExpression,
        IEditableMethodCallExpression<TExpression, TArgument>
        where TExpression : IEditableGenericExpression
        where TArgument : IEditableArgument
    {
        public abstract TExpression Expression { get; set; }

        public abstract IList<TArgument> Parameters { get; set; }

        IReadOnlyList<TArgument> IMethodCallExpression<TExpression, TArgument>.Parameters
        {
            get { return new ReadOnlyCollection<TArgument>(Parameters); }
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
