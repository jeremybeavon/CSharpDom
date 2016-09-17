using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableQueryFromExpression<TExpression, TQueryExpression> :
        IQueryFromExpression<TExpression, TQueryExpression>
        where TExpression : IExpression
        where TQueryExpression : IQueryExpression
    {
        public abstract TExpression Expression { get; set; }

        public abstract string Identifier { get; set; }

        public abstract IList<TQueryExpression> QueryExpressions { get; set; }

        IReadOnlyList<TQueryExpression> IQueryFromExpression<TExpression, TQueryExpression>.QueryExpressions
        {
            get { return new ReadOnlyCollection<TQueryExpression>(QueryExpressions); }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryFromExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryFromExpressionChildren(this, visitor);
        }
    }
}
