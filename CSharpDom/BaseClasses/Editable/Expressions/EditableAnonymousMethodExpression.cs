using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableAnonymousMethodExpression<TParameter, TStatement> :
        EditableExpression,
        IEditableAnonymousMethodExpression<TParameter, TStatement>
        where TParameter : IEditableAnonymousMethodParameter
        where TStatement : IEditableStatement
    {
        public abstract TStatement Body { get; set; }

        public abstract IList<TParameter> Parameters { get; set; }

        IReadOnlyList<TParameter> IAnonymousMethodExpression<TParameter, TStatement>.Parameters
        {
            get { return new ReadOnlyCollection<TParameter>(Parameters); }
        }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitAnonymousMethodExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitAnonymousMethodExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
        }
    }
}
