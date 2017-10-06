using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableAnonymousMethodExpression<TParameter, TStatement> :
        AbstractExpression,
        IAnonymousMethodExpression<TParameter, TStatement>
        where TParameter : IAnonymousMethodParameter
        where TStatement : IStatement
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

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
