using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryFromExpressionWithCodeAnalysis<TIdentifierExpression, TExpression, TQueryExpression> :
        IQueryFromExpression<TIdentifierExpression, TExpression, TQueryExpression>
        where TIdentifierExpression : IIdentifierExpression
        where TExpression : IExpression
        where TQueryExpression : IQueryExpression
    {
        public abstract TExpression Expression { get; set; }

        public abstract TIdentifierExpression Identifier { get; set; }

        public abstract IList<TQueryExpression> QueryExpressions { get; set; }

        IReadOnlyList<TQueryExpression> IQueryFromExpression<TIdentifierExpression, TExpression, TQueryExpression>.QueryExpressions
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
